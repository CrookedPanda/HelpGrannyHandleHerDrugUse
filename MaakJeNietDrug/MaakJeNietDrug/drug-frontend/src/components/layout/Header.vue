<template>
  <header class="header">
    <h1>Maak je niet drug</h1>
    <div id="nav">
      <b-navbar toggleable="lg" type="dark" variant="info">

    <b-navbar-toggle target="nav-collapse"></b-navbar-toggle>

    <b-collapse id="nav-collapse" is-nav>
      <b-navbar-nav>
        <b-nav-item to="/">Home</b-nav-item> 
      <b-nav-item to="/medicinelist">Medicine List</b-nav-item>
       </b-navbar-nav>
       </b-collapse>
  </b-navbar>
    </div>
  </header>
</template>

<script>
export default {
  name: "Header"
}
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