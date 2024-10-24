﻿using Domain.DTOs.Requests;
using Domain.DTOs.Responses;
using Domain.Entities;
using Microsoft.AspNetCore.Components.Forms;

namespace Domain.Interfaces;

/// <summary>
///     Represents an interface for the account service.
/// </summary>
public interface IAccountService
{
    #region Public methods declaration

    Task<BaseResponse> ChangePasswordAsync(ChangePasswordRequest request);

    Task<BaseResponse<User>> GetCurrentUserAsync();

    Task<List<UserResponse>> GetUsersAsync();

    /// <summary>
    ///     Registers a new user with the specified request.
    /// </summary>
    /// <param name="request">The request containing the user registration information.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the response.</returns>
    Task<BaseResponse> RegisterUserAsync(RegisterUserRequest request);

    Task<BaseResponse> RemoveUserAsync(string email);
    Task<BaseResponse> ResetAvatarAsync();
    Task<BaseResponse<string>> UploadAvatarAsync(IBrowserFile image);

    /// <summary>
    ///     Verifies the user with the specified email and password.
    /// </summary>
    /// <param name="email">The email of the user.</param>
    /// <param name="password">The password of the user.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the response with a string value.</returns>
    Task<BaseResponse<string>> VerifyUserAsync(string email, string password);

    #endregion
}