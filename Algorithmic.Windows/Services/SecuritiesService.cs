﻿using ShareInvest.Infrastructure.Http;
using ShareInvest.Mappers;
using ShareInvest.Models.OpenAPI.Observe;

namespace ShareInvest.Services;

class SecuritiesService
{
    internal SecuritiesService(string id)
    {
        this.id = id;
    }
    internal ISecuritiesMapper<AxMessageEventArgs> GetSecurities()
    {
        var api = new CoreRestClient();

        return new AxKH(api, id);
    }
    readonly string id;
}