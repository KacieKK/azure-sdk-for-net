// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// User create details.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class UserCreateParameters
    {
        /// <summary>
        /// Initializes a new instance of the UserCreateParameters class.
        /// </summary>
        public UserCreateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserCreateParameters class.
        /// </summary>
        /// <param name="email">Email address. Must not be empty and must be
        /// unique within the service instance.</param>
        /// <param name="firstName">First name.</param>
        /// <param name="lastName">Last name.</param>
        /// <param name="state">Account state. Specifies whether the user is
        /// active or not. Blocked users are unable to sign into the developer
        /// portal or call any APIs of subscribed products. Default state is
        /// Active. Possible values include: 'active', 'blocked', 'pending',
        /// 'deleted'</param>
        /// <param name="note">Optional note about a user set by the
        /// administrator.</param>
        /// <param name="identities">Collection of user identities.</param>
        /// <param name="password">User Password. If no value is provided, a
        /// default password is generated.</param>
        /// <param name="appType">Determines the type of application which send
        /// the create user request. Default is legacy portal. Possible values
        /// include: 'portal', 'developerPortal'</param>
        /// <param name="confirmation">Determines the type of confirmation
        /// e-mail that will be sent to the newly created user. Possible values
        /// include: 'signup', 'invite'</param>
        public UserCreateParameters(string email, string firstName, string lastName, string state = default(string), string note = default(string), IList<UserIdentityContract> identities = default(IList<UserIdentityContract>), string password = default(string), string appType = default(string), string confirmation = default(string))
        {
            State = state;
            Note = note;
            Identities = identities;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            AppType = appType;
            Confirmation = confirmation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets account state. Specifies whether the user is active or
        /// not. Blocked users are unable to sign into the developer portal or
        /// call any APIs of subscribed products. Default state is Active.
        /// Possible values include: 'active', 'blocked', 'pending', 'deleted'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets optional note about a user set by the administrator.
        /// </summary>
        [JsonProperty(PropertyName = "properties.note")]
        public string Note { get; set; }

        /// <summary>
        /// Gets or sets collection of user identities.
        /// </summary>
        [JsonProperty(PropertyName = "properties.identities")]
        public IList<UserIdentityContract> Identities { get; set; }

        /// <summary>
        /// Gets or sets email address. Must not be empty and must be unique
        /// within the service instance.
        /// </summary>
        [JsonProperty(PropertyName = "properties.email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets first name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets last name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets user Password. If no value is provided, a default
        /// password is generated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets determines the type of application which send the
        /// create user request. Default is legacy portal. Possible values
        /// include: 'portal', 'developerPortal'
        /// </summary>
        [JsonProperty(PropertyName = "properties.appType")]
        public string AppType { get; set; }

        /// <summary>
        /// Gets or sets determines the type of confirmation e-mail that will
        /// be sent to the newly created user. Possible values include:
        /// 'signup', 'invite'
        /// </summary>
        [JsonProperty(PropertyName = "properties.confirmation")]
        public string Confirmation { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Email == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Email");
            }
            if (FirstName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FirstName");
            }
            if (LastName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "LastName");
            }
            if (Email != null)
            {
                if (Email.Length > 254)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Email", 254);
                }
                if (Email.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Email", 1);
                }
            }
            if (FirstName != null)
            {
                if (FirstName.Length > 100)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "FirstName", 100);
                }
                if (FirstName.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "FirstName", 1);
                }
            }
            if (LastName != null)
            {
                if (LastName.Length > 100)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "LastName", 100);
                }
                if (LastName.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "LastName", 1);
                }
            }
        }
    }
}
