using Serendip.Entity;

namespace SK.SerendipGenericService.KKullaniciApi.Application.Dto
{
    public class KKullaniciDto : Entity
    {
        public long ObjId { get; set; }
        public string Email { get; set; }
    }
}