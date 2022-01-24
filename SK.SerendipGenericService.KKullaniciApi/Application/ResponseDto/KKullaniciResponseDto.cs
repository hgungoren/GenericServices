using Serendip.Entity;

namespace SK.SerendipGenericService.KKullaniciApi.Application.ResponseDto
{
    public class KKullaniciResponseDto : Entity
    {
        public long ObjId { get; set; }
        public string Email { get; set; }
    }
}