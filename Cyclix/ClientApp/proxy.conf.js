const { env } = require('process');

const target = env.ASPNETCORE_HTTPS_PORT ? `https://localhost:${env.ASPNETCORE_HTTPS_PORT}` :
  env.ASPNETCORE_URLS ? env.ASPNETCORE_URLS.split(';')[0] : 'http://localhost:9679';

const PROXY_CONFIG = [
  {
    context: [
      "/weatherforecast",
      "/brand",
      "/cycletype",
      "/repairrequest"
   ],
    target: target,
    secure: false,
    headers: {
      Connection: 'Keep-Alive'
    }
  }
  // {
  //   context: [
  //     "/brand",
  //  ],
  //   target: target,
  //   secure: false,
  //   headers: {
  //     Connection: 'Keep-Alive'
  //   }
  // },
  // {
  //   context: [
  //     "/cycletype",
  //  ],
  //   target: target,
  //   secure: false,
  //   headers: {
  //     Connection: 'Keep-Alive'
  //   }
  // },

]

module.exports = PROXY_CONFIG;
