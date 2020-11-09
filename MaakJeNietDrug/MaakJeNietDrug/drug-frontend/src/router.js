import Vue from 'vue'
import Router from 'vue-router'
import MedicineListPage from './Views/MedicineListPage.vue'
import AccountPage from './Views/AccountPage.vue'
import MedicinePage from './Views/MedicinePage.vue'

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
      {
        path: '/account',
        name: 'Account',
        component: AccountPage
      },
      {
        path: '/medicineDetail/:id',
        name: 'MedicineDetail',
        component: MedicinePage
      },      
  ]
})