import Vue from 'vue'
import App from './App.vue'
import router from './router'
import store from './store'
import AuthService from "./AuthService"

//Vue.config.productionTip = false

async function init() {
  console.log("hello")
  let user = await AuthService.Authenticate()
  console.log(user)
  if (user) { store.commit("setUser", user) }
  new Vue({
    router,
    store,
    render: h => h(App)
  }).$mount('#app')
}
init()

