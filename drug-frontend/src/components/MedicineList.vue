<template>
  <div>
    <table class="table table-striped">
      <thead class="thead-light">
        <th>Medicine id</th>
        <th>Medicine name</th>
      </thead>
      <tbody v-cloak>
        <div v-bind:key="medicine.id" v-for="medicine in medicineList">
          
            <Medicine v-bind:medicine="medicine" />
          
        </div>
      </tbody>
    </table>
  </div>
</template>

<script>

import Medicine from "./Medicine";

export default {
  name: "MedicineList",
  props: ["medicineList"],
  methods: {},
  components: {
    Medicine,
  },
};
</script>

<style scoped>
.rowstyle {
  color: blue;
  border: solid 3px red;
}
</style>