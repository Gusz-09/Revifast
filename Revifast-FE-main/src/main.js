import Vue from 'vue'
import App from './App.vue'
import router from './router'
import store from './store'
import vuetify from './plugins/vuetify';
import axios from 'axios';
import VueGtag from "vue-gtag";

Vue.use(VueGtag, {
  config: { id: "G-PDS580DXYY" }
});


Vue.config.productionTip = false
axios.defaults.baseURL='https://revifastapi2020isw.azurewebsites.net/'

new Vue({
  router,
  store,
  vuetify,
  render: h => h(App)
}).$mount('#app')
