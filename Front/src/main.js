import Vue from 'vue'
import App from './App.vue'
import VueResource from "vue-resource";

Vue.config.productionTip = false

Vue.use(VueResource);

var pamonhaAPI = 'http://172.16.0.153:20000/api/';
// var pamonhaAPI = 'http://localhost:20000/api/';

Vue.http.options.root = pamonhaAPI;

new Vue({
  render: h => h(App)
}).$mount('#app')
