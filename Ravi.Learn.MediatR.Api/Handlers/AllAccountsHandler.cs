using MediatR;
using Ravi.Learn.MediatR.Api.Messages;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Ravi.Learn.MediatR.Api.Handlers
{
    public class AllAccountsHandler : IRequestHandler<AccountsRequest, IEnumerable<AccountsResponse>>
    {
        public static readonly List<AccountsResponse> accounts = new List<AccountsResponse> {
                new AccountsResponse {Id = 1, Name = "Lisa Smith", Email = "lsmith@anywherecom"},
                new AccountsResponse {Id = 3, Name = "John Denver", Email = "jdenver@nowhere.com"},
                new AccountsResponse {Id = 5, Name = "Eric Deere", Email = "jdeere@gmail.com"}
            };
        public async Task<IEnumerable<AccountsResponse>> Handle(AccountsRequest request, CancellationToken cancellationToken)
        {
            return await Task.FromResult<IEnumerable<AccountsResponse>>(accounts);
        }
    }
}
