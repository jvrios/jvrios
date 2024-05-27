module.exports = {
  devServer: {
    proxy: {
      '/api': {
        target: 'https://localhost:7157',
        changeOrigin: true,
        secure: false,
        pathRewrite: { '^/api': '' }
      }
    }
  }
};
