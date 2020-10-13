<template>
   <div id="medicine-detail">
  <b-card no-body>
    <b-tabs content-class="mt-3" justified vertical>
      <b-tab title="Overzicht" ><b-card-text>{{medicine.name}}</b-card-text></b-tab>
      <b-tab title="Tab 2"><b-card-text>Tab contents 2</b-card-text></b-tab>
      <b-tab title="Tab 3"><b-card-text>Tab contents 3</b-card-text></b-tab>
    </b-tabs>
  </b-card>
</div> 
</template>


<script>
import axios from "axios";

export default {
    name: "MedicinePage",
    data(){
        return {
            id: this.$route.params.id,
            medicine: {}
        }
    },
    created(){
         axios
      .get("https://i338995core.venus.fhict.nl/Medicine/Get/" + this.id)
      .then((res) => (this.medicine = res.data))
      .catch((err) => console.log(err));
    }
}
</script>