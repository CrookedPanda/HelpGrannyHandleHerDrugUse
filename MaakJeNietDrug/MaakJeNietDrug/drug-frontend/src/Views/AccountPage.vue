<template>
  <div id="account-control">
    <b-tabs
      content-class="mt-5"
      justified
      align="center"
      active-nav-item-class="font-weight-bold text-danger"
    >
      <b-tab title="Inloggen">
        <Login v-on:log-in="inloggen"/>
      </b-tab>
      <b-tab title="Registeren">
        <Register v-on:reg-acc="CreateAccount"/>
      </b-tab>
    </b-tabs>
  </div>
</template>

<script>
import Login from "../components/Login";
import Register from "../components/Register";
//import axios from "axios";
import Vue from "vue";
import VueResizeText from "vue-resize-text";
Vue.use(VueResizeText);

export default {
  data() {
    return {
      name: "AccountPage",
      
    };
  },
  components: {
    Login,
    Register,
  },
  methods: {
    CreateAccount(obj) {
      return obj;
    },
    Inloggen(obj){
      console.log(obj)
    },
  },

};
</script>

<style scoped >

</style>


