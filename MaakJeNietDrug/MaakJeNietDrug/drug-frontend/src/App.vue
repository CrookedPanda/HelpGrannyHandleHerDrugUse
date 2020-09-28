<template>
  <div id="app">
    <MedicineList v-bind:medicineList="medicineList" />
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
</style>
