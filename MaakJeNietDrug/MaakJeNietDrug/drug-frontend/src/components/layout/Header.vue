<template>
  <header class="header">
    <h1>Maak je niet drug</h1>
    <div id="nav">
      <b-navbar toggleable="lg" type="dark" variant="secondary">
        <b-navbar-toggle target="nav-collapse"></b-navbar-toggle>

        <b-collapse id="nav-collapse" is-nav>
          <b-navbar-nav>
            <b-nav-item to="/" v-resize-text >Home</b-nav-item>
            <b-nav-item to="/medicinelist" v-resize-text>
              Medicine List</b-nav-item>
              <b-nav-item to="/account"  v-resize-text>
              Account</b-nav-item>
          </b-navbar-nav>
          <b-navbar-nav class="ml-auto">
            <b-button size="sm" class="my-2 my-sm-0" type="submit">Uitloggen</b-button>
          </b-navbar-nav>
        </b-collapse>
      </b-navbar>
    </div>
  </header>
</template>

<script>
import Vue from "vue";
import VueResizeText from "vue-resize-text";
Vue.use(VueResizeText);
export default {
  name: "Header",
};
</script>

<style scoped>
.header {
  background: #333;
  color: #fff;
  text-align: center;
  padding: 10px;
}
.header a {
  color: #fff;
  padding-right: 5px;
  text-decoration: none;
}

</style>