using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Portfolio.Domain.AppCode.Extensions;
using Portfolio.Domain.AppCode.Services;
using Portfolio.Domain.Models.Entities.Membership;
using Portfolio.Domain.Models.FormModels;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<PortfolioUser> signInManager;
        private readonly UserManager<PortfolioUser> userManager;
        private readonly EmailService emailService;

        public AccountController(SignInManager<PortfolioUser> signInManager, UserManager<PortfolioUser> userManager, EmailService emailService)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.emailService = emailService;
        }

        [AllowAnonymous]
        [Route("/signin.html")]
        public IActionResult Signin()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("/signin.html")]
        public async Task<IActionResult> Signin(LoginFormModel user)
        {
            PortfolioUser foundedUser = null;

            if (user.UserName == null || user.Password == null)
            {
                ViewBag.Message = "İstifadəçi adınız və ya şifrəniz yanlışdır";
                goto end;
            }

            if (user.UserName.IsEmail())
            {
                foundedUser = await userManager.FindByEmailAsync(user.UserName);
            }
            else if (user.UserName.IsEmail())
            {
                foundedUser = await userManager.FindByNameAsync(user.UserName);
            }
            else
            {
                goto end;
            }

            


            if (foundedUser == null)
            {
                ViewBag.Message = "İstifadəçi adınız və ya şifrəniz yanlışdır";
                goto end;
            }

            var signInResult = await signInManager.PasswordSignInAsync(foundedUser, user.Password, true, true);

            

            if (!signInResult.Succeeded)
            {
                ViewBag.Message = "İstifadəçi adınız və ya şifrəniz yanlışdır";
                goto end;
            }

            var callbackUrl = Request.Query["ReturnUrl"];

            if (!string.IsNullOrWhiteSpace(callbackUrl))
            {
                return Redirect(callbackUrl);
            }
            return RedirectToAction("Index", "Blog");

        end:
            return View(user);
        }

        [AllowAnonymous]
        [Route("/register.html")]
        public IActionResult Register()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("/register.html")]
        public async Task<IActionResult> Register(RegisterFormModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new PortfolioUser();

                user.Email = model.Email;
                user.UserName = model.Email;
                user.Name = model.Name;
                user.Surname = model.Surname;
                //user.EmailConfirmed = true;

                var result = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    var token = await userManager.GenerateEmailConfirmationTokenAsync(user);
                    string path = $"{Request.Scheme}://{Request.Host}/registration-confirm.html?email={user.Email}&token={token}";

                    var emailResponse = await emailService.SendEmailAsync(user.Email, "Registration for Ali's blog", $"Abuneliyinizi <a href='{path}'>link</a> vasitesile tesdiq edin");

                    if (emailResponse)
                    {
                        ViewBag.Message = "Qeydiyyat uğurla tamamlandı";
                    }
                    else
                    {
                        ViewBag.Message = " E-mail' göndərərkən xəta baş verdi, zəhmət olmasa yenidən cəhd edin";
                    }

                    return RedirectToAction(nameof(Signin));
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }
            }

            return View(model);

        }

        [AllowAnonymous]
        [Route("registration-confirm.html")]
        public async Task<IActionResult> RegisterConfirm(string email, string token)
        {
            var foundedUser = await userManager.FindByEmailAsync(email);
            if (foundedUser == null)
            {
                ViewBag.Message = "Xətalı token";
                goto end;
            }
            token = token.Replace(" ", "+");
            var result = await userManager.ConfirmEmailAsync(foundedUser, token);

            if (!result.Succeeded)
            {
                ViewBag.Message = "Xetalı token";
                goto end;
            }

            ViewBag.Message = "Hesabınız təsdiqləndi";
        end:
            return RedirectToAction(nameof(Signin));
        }

        [Route("/logout.html")]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();

            return RedirectToAction("Index","home");
        }
    }
}
