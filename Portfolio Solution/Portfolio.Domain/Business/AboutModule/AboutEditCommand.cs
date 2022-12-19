using MediatR;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.AppCode.Infrastructure;
using Portfolio.Domain.Models.DataContext;
using Portfolio.Domain.Models.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Domain.Business.AboutModule
{
    public class AboutEditCommand : IRequest<JsonResponse>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Location { get; set; }
        public int Experince { get; set; }
        public string Degree { get; set; }
        public string CareerLevel { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string FacebookLink { get; set; }
        public string GithubLink { get; set; }
        public string LinkedinLink { get; set; }
        public string InstagramLink { get; set; }
        public string YoutubeLink { get; set; }



        public class AboutEditCommandHandler : IRequestHandler<AboutEditCommand, JsonResponse>
        {
            private readonly PortfolioDbContext db;

            public AboutEditCommandHandler(PortfolioDbContext db)
            {
                this.db = db;
            }

            public async Task<JsonResponse> Handle(AboutEditCommand request, CancellationToken cancellationToken)
            {
                var data = await db.Abouts
                    .FirstOrDefaultAsync(m => m.Id == request.Id && m.DeletedDate == null, cancellationToken);

                if (data == null)
                {
                    return null;
                }

                data.Name = request.Name;
                data.Age = request.Age;
                data.Location = request.Location;
                data.Experince = request.Experince;
                data.Degree = request.Degree;
                data.CareerLevel = request.CareerLevel;
                data.Phone = request.Phone;
                data.Fax = request.Fax;
                data.Email = request.Email;
                data.Website = request.Website;
                data.ShortDescription = request.ShortDescription;
                data.LongDescription = request.LongDescription;
                data.FacebookLink = request.FacebookLink;
                data.GithubLink = request.GithubLink;
                data.LinkedinLink = request.LinkedinLink;
                data.InstagramLink = request.InstagramLink;
                data.YoutubeLink = request.YoutubeLink;


                await db.SaveChangesAsync(cancellationToken);


                return new JsonResponse
                {
                    Error = false,
                    Message = "Muracietiniz qeyde alindi. Tezlikle geri donush edilecek."
                };

            }


        }
    }
}
