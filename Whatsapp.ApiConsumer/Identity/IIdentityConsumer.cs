using Refit;
using WhatsAppScrapper.Models.Refit;

namespace Whatsapp.ApiConsumer.Identity
{
    public interface IIdentityConsumer
    {
        [Post("/Identity/Tokenvalidate")]
        Task<IdentityResponse<bool>> Tokenvalidate(TokenRequest request);

        [Get("/User/UserInfo")]
        [Headers("Authorization: Bearer")]
        Task<IdentityResponse<UserInfo>> UserInfo();
    }
}