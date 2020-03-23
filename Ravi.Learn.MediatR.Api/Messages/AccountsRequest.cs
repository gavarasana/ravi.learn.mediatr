using MediatR;
using System.Collections.Generic;

namespace Ravi.Learn.MediatR.Api.Messages
{
    public class AccountsRequest : IRequest<IEnumerable<AccountsResponse>>
    {
    }
}
