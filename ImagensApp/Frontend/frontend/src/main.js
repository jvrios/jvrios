import { createApp } from 'vue';
import App from './App.vue';

const app = createApp(App);

// Define Vue.js feature flags here
app.config.devtools = false;
app.config.productionTip = false;

app.mount('#app');
