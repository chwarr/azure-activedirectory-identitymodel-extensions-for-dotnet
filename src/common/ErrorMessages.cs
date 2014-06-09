﻿//-----------------------------------------------------------------------
// Copyright (c) Microsoft Open Technologies, Inc.
// All Rights Reserved
// Apache License 2.0
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//-----------------------------------------------------------------------

using System.Diagnostics.CodeAnalysis;

namespace Microsoft.IdentityModel
{
    /// <summary>
    /// Error codes and messages
    /// </summary>
    [ SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:ElementsMustBeDocumented", Justification = "Reviewed. Suppression is OK here.")]
    public static class ErrorMessages
    {
        #pragma warning disable 1591
        // general messages 10000 - 10099
        public const string IDX10000 = "IDX10000: The parameter '{0}' cannot be a 'null' or an empty string.";
        public const string IDX20000 = "IDX20000: The property value '{0}' cannot be a 'null' or an empty string.";
        public const string IDX30000 = "IDX30000: The parameter '{0}' cannot be 'null' or a string containing only whitespace.";

        // messages pertaining to setting protperties, configuration 
        public const string IDX10100 = "IDX10100: ClockSkew must be greater than TimeSpan.Zero. value: '{0}'";
        public const string IDX10101 = "IDX10101: MaximumTokenSizeInBytes must be greater than zero. value: '{0}'";
        public const string IDX10102 = "IDX10102: NameClaimType cannot be null or whitespace.";
        public const string IDX10103 = "IDX10103: RoleClaimType cannot be null or whitespace.";
        public const string IDX10104 = "IDX10104: TokenLifetimeInMinutes must be greater than zero. value: '{0}'";

        // messages pertaining to validation 10200 - 10299
        public const string IDX10200 = "IDX10200: Support for ValidateToken(string, TokenValidationParameters) requires a handler to implement ISecurityTokenValidator, none of the SecurityTokenHandlers did.";
        public const string IDX10201 = "IDX10201: None of the the SecurityTokenHandlers could read the 'securityToken': '{0}'.";
        public const string IDX10202 = "IDX10202: SamlToken.Assertion is null, can not create an identity.";
        public const string IDX10203 = "IDX10203: Unable to create ClaimsIdentity. Issuer is null or whitespace.";
        public const string IDX10204 = "IDX10204: Unable to validate issuer. validationParameters.ValidIssuer is null or whitespace AND validationParameters.ValidIssuers is null.";
        public const string IDX10205 = "IDX10205: Issuer validation failed. Issuer: '{0}'. Did not match: validationParameters.ValidIssuer: '{1}' or validationParameters.ValidIssuers: '{2}'.";
        //public const string IDX10206 = "IDX10206: Unable to validate issuer, 'securityToken' type was not a: '{0}', was a: '{1}'";
        public const string IDX10207 = "IDX10207: Unable to validate audience, o audiences to .";
        public const string IDX10208 = "IDX10208: Unable to validate audience. validationParameters.ValidAudience is null or whitespace and validationParameters.ValidAudiences is null.";
        public const string IDX10209 = "IDX10209: 'tokenString' has length: '{0}' which is larger than the MaximumTokenSizeInBytes: '{1}'.";
        public const string IDX10210 = "IDX10210: SamlToken.Assertion.Issuer is null, can not create an identity.";
        public const string IDX10211 = "IDX10211: Unable to validate issuer. The 'issuer' parameter is null or whitespace";
        public const string IDX10212 = "IDX10212: {0} can only validate tokens of type {1}.";
        public const string IDX10213 = "IDX10213: SecurityTokens must be signed. SecurityToken: '{0}'.";
        public const string IDX10214 = "IDX10214: Audience validation failed. Audiences: '{0}'. Did not match:  validationParameters.ValidAudience: '{1}' or validationParameters.ValidAudiences: '{2}'";
        public const string IDX10215 = "IDX10215: Audience validation failed. Audiences passed in was null";
        public const string IDX10216 = "IDX10216: Lifetime validation failed. 'NotBefore' preceeds the current time: '{0}', ClockSkew (InSeconds): '{1}', notbefore: '{2}'";
        public const string IDX10217 = "IDX10217: Lifetime validation failed. 'NotOnOrAfter' is after the current time: '{0}', ClockSkew (InSeconds): '{1}', notbefore: '{2}'";
        public const string IDX10218 = "IDX10218: OneTimeUse is not supported";
        public const string IDX10219 = "IDX10219: ProxyRestriction is not supported";
        public const string IDX10220 = "IDX10220: Jwks_Uri must be an absolute uri. Was: ";
        public const string IDX10221 = "IDX10221: Unable to create claims from securityToken, 'issuer' is null or empty.";
        public const string IDX10222 = "IDX10222: Lifetime validation failed. The token is not yet valid.\nValidFrom: '{0}'\nCurrent time: '{1}'.";
        public const string IDX10223 = "IDX10223: Lifetime validation failed. The token is expired.\nValidTo: '{0}'\nCurrent time: '{1}'.";
        public const string IDX10224 = "IDX10224: Lifetime validation failed. The NotBefore: '{0}' is after Expires: '{1}'.";
        public const string IDX10225 = "IDX10225: Lifetime validation failed. The token is missing an Expiration Time.\nTokentype: '{0}'.";
        public const string IDX10226 = "IDX10226: '{0}' can only write SecurityTokens of type: '{1}', 'token' type is: '{2}'.";

        // protocol messages
        public const string IDX10300 = "IDX10300: A claim of type: '{0}', representing the nonce was not found in the jwt: '{1}'.";
        public const string IDX10301 = "IDX10301: The 'nonce' found in the jwt token: '{0}', did not match the expected nonce: '{1}'.";
        public const string IDX10302 = "IDX10302: The 'c_hash' claim was not a JSON string but multivalued, jwt: '{0}'.";
        public const string IDX10303 = "IDX10303: The 'c_hash' claim was null or an empty string, jwt: '{0}'.";
        public const string IDX10304 = "IDX10304: The c_hash: '{0}' did not validate with the code: '{1}', algorithm: '{2}', jwt: '{3}'.";
        public const string IDX10305 = "IDX10305: The 'nonce' found in the jwt token: '{0}',  did not match the expected nonce: '{1}', hwt: '{3}'.";
        public const string IDX10306 = "IDX10306: The algorithm: '{0}' specified in the jwt header was unable to create a hashAlgorithm, jwt: '{1}'. See inner exception for details.\nPossible solution is to ensure that the algorithm specified in the 'JwtHeader' is understood by .Net. You can make additions to the OpenIdConnectProtocolValidationParameters.AlgorithmMap to map algorithms from the 'Jwt' space to .Net. In .Net you can also make use of 'CryptoConfig' to map algorithms.";
        public const string IDX10307 = "IDX10307: The algorithm: '{0}' specified in the jwt header resulted in a hashAlgorithm that was null,  jwt: '{1}'.";
        public const string IDX10308 = "IDX10308: The 'c_hash' claim was not found in the jwt: '{0}'.";
        public const string IDX10309 = "IDX10309: OpenIdConnectProtocol requires the jwt token to have an '{0}' claim. The jwt did not contain an '{0}' claim, jwt: '{1}'.";
        public const string IDX10310 = "IDX10310: OpenIdConnectProtocol requires the jwt token to have a  valid 'aud' claim. The jwt 'aud' did not contain any values, jwt: '{0}'.";
 
        // SecurityTokenHandler messages
        public const string IDX10400 = "IDX10400: The '{0}', can only process SecurityTokens of type: '{1}'. The SecurityToken received is of type: '{2}'.";
        public const string IDX10401 = "IDX10401: Expires: '{0}' must be after NotBefore: '{1}'.";


        // utility errors
        public const string IDX10600 = "IDX10600: Unable to decode: '{0}' as Base64url encoded string.";

        // NotSupported Exceptions
        public const string IDX11000 = "IDX11000: This method is not supported to validate a 'saml2token' use the method: ValidateToken(String, TokenValidationParameters, out SecurityToken).";
        public const string IDX11001 = "IDX11001: This method is not supported to validate a 'samltoken' use the method: ValidateToken(String, TokenValidationParameters, out SecurityToken).";
        public const string IDX11002 = "IDX11002: This method is not supported to read a 'saml2token' use the method: ReadToken(XmlReader reader, TokenValidationParameters validationParameters).";
        public const string IDX11003 = "IDX11003: This method is not supported to read a 'samltoken' use the method: ReadToken(XmlReader reader, TokenValidationParameters validationParameters).";
        public const string IDX11004 = "IDX11004: Loading from Configuration is not supported use TokenValidationParameters to set validation parameters.";
        public const string IDX11005 = "IDX11005: Creating a SecurityKeyIdentifierClause is not supported.";
        public const string IDX11006 = "IDX11006: This method is not supported to read a 'saml2token' use the method: ReadToken(string securityToken, TokenValidationParameters validationParameters).";
        public const string IDX11007 = "IDX11007: This method is not supported to read a 'samltoken' use the method: ReadToken(string securityToken, TokenValidationParameters validationParameters).";
        #pragma warning restore 1591


    }
}