<template>
    <div id="account-control">
        <b-tabs 
        content-class="mt-5" 
        justified 
        align="center"
        active-nav-item-class="font-weight-bold text-danger"
        >
            <b-tab title="Inloggen" active >
                <Login/>
            </b-tab>
            <b-tab title="Registeren" >
                <Register/>
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
    name: "AccountPage",
    components:{
        Login, 
        Register,
    },
    methods:{
        CreateAccount(obj){
            return obj;
        }
    }
}
</script>

<style scoped>

</style>


