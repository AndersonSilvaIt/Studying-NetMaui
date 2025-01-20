﻿using AppLanches.Models;
using Microsoft.Extensions.Logging;
using System.Text;
using System.Text.Json;

namespace AppLanches.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl = "https://mzv66v96-7066.brs.devtunnels.ms/";
        private readonly ILogger<ApiService> _logger;
        JsonSerializerOptions _serializerOptions;

        public ApiService(HttpClient httpClient,
                          ILogger<ApiService> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
            _serializerOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

        }

        public async Task<ApiResponse<bool>> RegistrarUsuario(string nome, string email, string telefone, string password)
        {
            try
            {
                var register = new Register
                {
                    Nome = nome,
                    Email = email,
                    Telefone = telefone,
                    Senha = password
                };

                var json = JsonSerializer.Serialize(register, _serializerOptions);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await PostRequest("api/Usuarios/Register", content);

                if (!response.IsSuccessStatusCode)
                {
                    _logger.LogError($"erro ao enviar requisição HTTP: {response.StatusCode}");

                    return new ApiResponse<bool>
                    {
                        ErrorMessage = $"erro ao enviar requisição HTTP: {response.StatusCode}"
                    };
                }

                return new ApiResponse<bool> { Data = true };
            }
            catch (Exception ex)
            {
                _logger.LogError($"Erro ao registrar o usuário: {ex.Message}");
                return new ApiResponse<bool> { ErrorMessage = ex.Message };
            }
        }

        public async Task<ApiResponse<bool>> Login(string email, string password)
        {
            try
            {
                var register = new Login
                {
                    Email = email,
                    Password = password
                };

                var json = JsonSerializer.Serialize(register, _serializerOptions);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await PostRequest("api/Usuarios/Login", content);

                if (!response.IsSuccessStatusCode)
                {
                    _logger.LogError($"erro ao enviar requisição HTTP: {response.StatusCode}");

                    return new ApiResponse<bool>
                    {
                        ErrorMessage = $"erro ao enviar requisição HTTP: {response.StatusCode}"
                    };
                }

                var jsonResult = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<Token>(jsonResult, _serializerOptions);

                Preferences.Set("accesstoken", result!.AccessToken);
                Preferences.Set("usuarioid", (int)result!.UserId!);
                Preferences.Set("usuarionome", result!.UserName);

                return new ApiResponse<bool> { Data = true };
            }
            catch (Exception ex)
            {
                _logger.LogError($"Erro no login: {ex.Message}");
                return new ApiResponse<bool> { ErrorMessage = ex.Message };
            }
        }



        private async Task<HttpResponseMessage> PostRequest(string uri, HttpContent content)
        {
            var enderecoUrl = _baseUrl + uri;

            try
            {
                var result = await _httpClient.PostAsync(enderecoUrl, content);
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Erro ao enviar requisição POST para {uri} : {ex.Message}");
                return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest);
            }
        }

    }



}

