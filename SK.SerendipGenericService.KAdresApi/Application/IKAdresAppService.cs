using SK.SerendipGenericService.KAdresApi.Application.ResponseDto;

namespace SK.SerendipGenericService.KAdresApi.Application
{
    public interface IKAdresAppService
    {
        KAdresResponseDto GetReceiverAddressAsync(string takipNo);

        KAdresResponseDto GetSenderAddressAsync(string takipNo);
    }
}
