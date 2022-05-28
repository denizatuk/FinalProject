using Core.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;
using static Core.Entities.Concretes.User;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user,List<OperationClaim> operationClaims);
    }
}
