<template>
   <div id="medicine-detail" align="center">
       <h1>{{medicine.name}}</h1>
  <b-card no-body style="max-width: 75%;" >
    <b-tabs pills card vertical class="text-left">
      <b-tab title="Waarvoor" ><b-card-text>{{medicine.description}}</b-card-text></b-tab>
      <b-tab title="Wanneer niet te gebruiken"><b-card-text>Tab contents 2</b-card-text></b-tab>
       <b-tab title="Gebruik"><b-card-text>Tab contents 3</b-card-text></b-tab>
      <b-tab title="Mogelijke Bijwerkingen"><b-card-text>Tab contents 3</b-card-text></b-tab>    
      <b-tab title="Hoe bewaar ik dit middel"><b-card-text>Tab contents 3</b-card-text></b-tab>
    <!--  <b-tab title="Notities"><b-card-text>Tab contents 3</b-card-text></b-tab> -->
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