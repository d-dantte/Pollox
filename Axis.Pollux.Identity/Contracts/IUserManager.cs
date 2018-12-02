﻿using System;
using Axis.Luna.Operation;
using Axis.Pollux.Common.Utils;
using Axis.Pollux.Identity.Models;

namespace Axis.Pollux.Identity.Contracts
{
    public interface IUserManager
    {
        #region User

        Operation<User> CreateUser(int? status = null);
        Operation<User> DeleteUser(Guid userId);
        Operation UpdateUserStatus(Guid userId, int status);

        Operation<User> GetUser(Guid userId);
        Operation<UserProfile> GetUserProfile(Guid userId);
        Operation<long> UserCount();

        #endregion

        #region BioData

        Operation<BioData> CreateBioData(Guid userId, BioData bioData);
        Operation<BioData> DeleteBioData(Guid bioDataId);
        Operation<BioData> UpdateBioData(BioData bioData);
        Operation UpdateBioDataStatus(Guid bioDataId, int status);

        Operation<BioData> GetUserBioData(Guid bioDataId);

        #endregion

        #region AddressData

        Operation<AddressData> AddAddressData(Guid userId, AddressData addressData);
        Operation<AddressData> DeleteAddressData(Guid addressDataId);
        Operation<AddressData> UpdateAddressData(AddressData addressData);
        Operation UpdateAddressDataStatus(Guid addressDataId, int status);

        Operation<AddressData> GetAddressData(Guid addressDataId);
        Operation<ArrayPage<AddressData>> GetUserAddresses(Guid userId, ArrayPageRequest request = null);

        #endregion

        #region ContactData

        Operation<ContactData> AddContactData(Guid userId, ContactData contactData);
        Operation<ContactData> DeleteContactData(Guid contactDataId);
        Operation<ContactData> UpdateContactData(ContactData contactData);
        Operation UpdateContactDataStatus(Guid contactDataId, int status);

        Operation<ContactData> GetContactData(Guid contactDataId);
        Operation<ArrayPage<ContactData>> GetUserContact(Guid userId, ArrayPageRequest request = null);

        #endregion

        #region NameData

        Operation<NameData> AddNameData(Guid userId, NameData nameData);
        Operation<NameData> DeleteNameData(Guid nameDataId);
        Operation<NameData> UpdateNameData(NameData nameData);
        Operation UpdateNameDataStatus(Guid nameDataId, int status);

        Operation<NameData> GetNameData(Guid nameDataId);
        Operation<ArrayPage<NameData>> GetUserName(Guid userId, ArrayPageRequest request = null);

        #endregion

        #region UserData

        Operation<UserData> AddUserData(Guid userId, UserData userData);
        Operation<UserData> DeleteUserData(Guid userDataId);
        Operation<UserData> UpdateUserData(UserData userData);
        Operation UpdateUserDataStatus(Guid userDataId, int status);

        Operation<UserData> GetUserData(Guid userDataId);
        Operation<ArrayPage<UserData>> GetUserUser(Guid userId, ArrayPageRequest request = null);

        #endregion

    }
}
