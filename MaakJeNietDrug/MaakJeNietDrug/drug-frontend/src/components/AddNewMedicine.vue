<template>
  <div>
    <b-form inline @submit="addMedicine" class="b-form" align-h="center">
      <label class="sr-only" for="inline-form-input-id">Id</label>
      <b-input
        type="number"
        id="inline-form-input-id"
        class="ml-auto mr-sm-2"
        placeholder="10"
        v-model="id"
      ></b-input>
      <label class="sr-only" for="inline-form-input-title">Title</label>
      <b-input
      
        id="inline-form-input-id"
        class="mr-sm-2"
        placeholder="Your title"
        v-model="title"
      ></b-input>
      <label class="sr-only" for="inline-form-input-id">Description</label>
      <b-textarea
      id="inline-form-input-description"
        class="mr-2 w-25"
        placeholder="Your description"
        v-model="description"
      
      ></b-textarea>
      

      <b-button type="submit" variant="primary" class="mr-auto">Add</b-button>
    </b-form>
  </div>
</template>


<script>
export default {
  name: "AddNewMedicine",
  data() {
    return {
      id: 10,
      title: "",
      description: "",
    };
  },
  methods: {
    addMedicine(e) {
      e.preventDefault();
      const newMed = {
        id: this.id,
        title: this.title,
        description: this.description,
      };
      this.$emit("add-medicine", newMed);
      this.id = 10;
      this.title = "";
      this.description = "";
    },
  },
};
</script>

<style scoped>
</style>
