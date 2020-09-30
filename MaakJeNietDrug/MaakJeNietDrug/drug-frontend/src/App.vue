
<template>

  <div id="app">
        <label  @click="ToggleNMS">Toggle adding screen</label>
    <AddNewMedicine v-on:add-medicine="AddNewMed" v-if="showNewMed" /> 

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
import AddNewMedicine from "./components/AddNewMedicine";
import axios from "axios"

export default {
  name: "App",
  components: {
    //Header
    MedicineList,
    AddNewMedicine,
  },
  data() {
    return {
            medicineList: [
        {
          id: 100,
          title: "med1",
          description: "test1"
        },
        {
          id: 2,
          title: "med2",
          description: "test2"
        },
        {
          id: 3,
          title: "med3",
          description: "test3"
        },
        {
          id: 4,
          title: "med4",
          description: "test4"
        },
        {
          id: 5,
          title: "med5",
          description: "test5"
        },
        {
          id: 6,
          title: "med6",
          description: "test6"
        },
      ],
      showNewMed: false,
      

    };
  },
  methods: {
    AddNewMed(newMed) {
      //const{id, title, description} = newMed;
      this.medicineList = [...this.medicineList, newMed];
    },
    ToggleNMS() {
      this.showNewMed = !this.showNewMed;
    }
  }

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
