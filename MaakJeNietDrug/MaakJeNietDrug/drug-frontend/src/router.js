import Vue from 'vue'
import Router from 'vue-router'
import MedicineListPage from './Views/MedicineListPage.vue'

Vue.use(Router)


 export default new Router({
  routes: [
    {
        path: '/',
        name: 'Home',
        component: () => import(/* webpackChunkName: "about" */ './Views/Home.vue')
      },
      {
        path: '/medicinelist',
        name: 'MedicineList',
        component: MedicineListPage
      },
  ]
})