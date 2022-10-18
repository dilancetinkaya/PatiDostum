using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Core.Jwt;

    public class GenerateJwt
    {
    //sınıf ,metot ,interface-sınıf(depency için mi?),dictionary
    public static JwtSecurityToken GetJwtToken(string username, string signingKey,
             string issuer, string audience, TimeSpan expiration, Claim[] additionalClaims = null)
    {
        var claims = new[]
        {
                new Claim(JwtRegisteredClaimNames.Sub,username),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

        if (additionalClaims != null/*is object*//*.Any()*/)
        {
            var claimList = claims.ToList() /*new List<Claim>(claims)*/;
            claimList.AddRange(additionalClaims);
            claims = claimList.ToArray();
        }

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(signingKey /*buraya token key değeri strimg olarak mı gelmeli?*/));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        return new JwtSecurityToken(
            issuer: issuer,
            audience: audience,
            expires: DateTime.UtcNow.Add(expiration),
            claims: claims,
            signingCredentials: creds
        );
    }
}

