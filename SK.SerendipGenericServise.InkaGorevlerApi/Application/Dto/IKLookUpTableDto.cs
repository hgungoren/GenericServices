using System.ComponentModel.DataAnnotations;

namespace SK.SerendipGenericServise.InkaGorevlerApi.Application.Dto
{
    public class IKLookUpTableDto
    {

        public string Adi { get; set; }
        public string Aciklama { get; set; }
        public string ParentKodu { get; set; }
        public bool? Aktif { get; set; }

    }
}