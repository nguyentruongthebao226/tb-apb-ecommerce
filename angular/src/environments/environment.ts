import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'AbpEcommerce',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44338/',
    redirectUri: baseUrl,
    clientId: 'AbpEcommerce_App',
    responseType: 'code',
    scope: 'offline_access AbpEcommerce',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44389',
      rootNamespace: 'TheBao.AbpEcommerce',
    },
  },
} as Environment;
