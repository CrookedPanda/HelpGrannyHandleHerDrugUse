
<template>

  <div id="app">
    
    <div class="container">
      <div class="card mt-5">
        
        <h2 class="card-header">Your medicines</h2>
        <MedicineList v-bind:medicineList="medicineList"/>
      
      </div>
    </div>
  </div>
</template>

<script>
import MedicineList from "./components/MedicineList";
import "bootstrap";

export default {
  name: "App",
  components: {
    //Header
    MedicineList,
  },
  data() {
    return {
      medicineList: [
        {
          id: 1,
          name: "med1",
        },
        {
          id: 2,
          name: "med2",
        },
        {
          id: 3,
          name: "med3",
        },
        {
          id: 4,
          name: "med4",
        },
        {
          id: 5,
          name: "med5",
        },
        {
          id: 6,
          name: "med6",
        },
      ],
    };
  },
};
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
.card-header:first-child {
    border-radius: calc(.25rem - 1px) calc(.25rem - 1px) 0 0;
}
.card-header {
    padding: .75rem 1.25rem;
    margin-bottom: 0;
    background-color: rgba(0,0,0,.03);
    border-bottom: 1px solid rgba(0,0,0,.125);
}
.mt-5, .my-5 {
    margin-top: 3rem!important;
}
.card {
    position: relative;
    display: -ms-flexbox;
    display: flex;
    -ms-flex-direction: column;
    flex-direction: column;
    min-width: 0;
    word-wrap: break-word;
    background-color: #fff;
    background-clip: border-box;
    border: 1px solid rgba(0,0,0,.125);
    border-radius: .25rem;
}
.m-3 {
    margin: 1rem!important;
}
.table {
    width: 100%;
    margin-bottom: 1rem;
    color: #212529;
}
table {
    border-collapse: collapse;
}
*, ::after, ::before {
    box-sizing: border-box;
}
table {
    display: table;
    border-collapse: separate;
    box-sizing: border-box;
    border-spacing: 2px;
    border-color: grey;
}
*, ::after, ::before {
    box-sizing: border-box;
}
thead {
    display: table-header-group;
    vertical-align: middle;
    border-color: inherit;
}
tr {
    display: table-row;
    vertical-align: inherit;
    border-color: inherit;
}


</style>
