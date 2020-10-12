<template>
  <div>

    
    <b-button variant="outline-primary" v-b-modal.voeg-medicijn-toe-modal>
      Klik hier om nieuw medicijn toe te voegen!
    </b-button>
    <b-modal id="voeg-medicijn-toe-modal">
      <form>
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
      </form>
    <template v-slot:modal-footer>
      <b-button type="submit" variant="primary" class="mr-auto" @click="addMedicine()">Toevoegen</b-button>
    </template>
    </b-modal>
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
      
      showNewMed: false,
    };
  },
  methods: {
    addMedicine() {
      e.preventDefault();
      const newMed = {
        name: this.name,
        description: this.description,
      };
      this.$emit("add-medicine", newMed);
      this.name = "";
      this.description = "";
    },
    
    ToggleNMS() {
      this.showNewMed = !this.showNewMed;
    },
  },
};
</script>

<style scoped>
</style>


<b-form inline @submit="addMedicine" class="b-form" align-h="center">
      
      <label class="sr-only" for="inline-form-input-title">Name</label>
      <b-input
      
        id="inline-form-input-id"
        class="ml-auto mr-sm-2"
        placeholder="Your title"
        v-model="name"
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