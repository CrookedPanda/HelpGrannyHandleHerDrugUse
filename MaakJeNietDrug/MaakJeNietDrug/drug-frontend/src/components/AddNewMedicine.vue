<template>
  <div>
    <b-form inline @submit="addMedicine" class="b-form" align-h="center">
      
      <label class="sr-only" for="inline-form-input-title">Naam</label>
      <b-input
      
        id="inline-form-input-id"
        class="ml-auto mr-sm-2"
        placeholder="Uw titel"
        v-model="name"
      ></b-input>
      <label class="sr-only" for="inline-form-input-id">Beschrijving</label>
      <b-textarea
      id="inline-form-input-description"
        class="mr-2 w-25"
        placeholder="Uw beschrijving"
        v-model="description"
      
      ></b-textarea>
      

      <b-button type="submit" variant="primary" class="mr-auto">Toevoegen</b-button>
    </b-form>
  </div>
</template>


<script>
export default {
  name: "AddNewMedicine",
  data() {
    return {
      id: 10,
      name: "",
      description: "",
    };
  },
  methods: {
    addMedicine() {
      //e.preventDefault();
      const newMed = {
        id: this.id,
        name: this.name,
        description: this.description,
      };
      this.$emit("add-medicine", newMed);
      this.id = 10;
      this.name = "";
      this.description = "";
    },
  },
};
</script>

<style scoped>
</style>
