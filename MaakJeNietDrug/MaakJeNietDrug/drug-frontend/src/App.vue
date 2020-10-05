
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
          id: 100,
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


</style>
