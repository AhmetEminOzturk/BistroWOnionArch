using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BistroWOnionArch.Core.Application.Dtos.WelcomeBanner.Requests
{
    public class UpdateWelcomeBannerRequest
    {
        public int WelcomeBannerId { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Title3 { get; set; }
        public string ImageUrl1 { get; set; }
        public string ImageUrl2 { get; set; }
        public string ImageTitle1 { get; set; }
        public string ImageTitle2 { get; set; }
    }
}
