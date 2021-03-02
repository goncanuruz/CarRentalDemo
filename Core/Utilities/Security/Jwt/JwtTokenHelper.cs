using Core.Entities.Concrete;
using Core.Utilities.Security.Encryption;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Core.Utilities.Security.Jwt
{
    public class JwtTokenHelper : ITokenHelper
    {
        public IConfiguration Configuration { get;}
        TokenOptions _tokenOptions;
        DateTime AccessTokenExpiration;
        public JwtTokenHelper(IConfiguration configuration)
        {
            Configuration = configuration;
            _tokenOptions = configuration.GetSection("TokenOptions").Get<TokenOptions>();
            AccessTokenExpiration = DateTime.Now.AddMinutes(_tokenOptions.AccessTokenExpiration);
        }
        public AccessToken CreateToken(User user, List<OperationClaim> operationClaims)
        {
            var securityKey = SecurityKeyHelper.CreateSecurityKey(_tokenOptions.SecurityKey);
            var signingCredential = SigningCredentialsHelper.CreateSigningCredentials(securityKey);
            return null;


        }
        public JwtSecurityToken CreateJwcSecurityToken
            (TokenOptions tokenOptions,User user,SigningCredentials signingCredentials,List<OperationClaim>operationClaims)
        {
            var jwt = new JwtSecurityToken(
                issuer:tokenOptions.Issuer,
                audience:tokenOptions.Audience,
                notBefore:DateTime.Now,
                expires:AccessTokenExpiration,
                signingCredentials:signingCredentials,
                claims:operationClaims

                );

        }
        public IEnumerable<Claim> SetClaims(User user, List<OperationClaim> operationClaims)
        {
            var claims = new List<Claim>();
            claims.Add(new Claim("email",user.Email));

        }

    }
}
