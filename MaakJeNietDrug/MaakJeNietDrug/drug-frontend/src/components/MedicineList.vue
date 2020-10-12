<template>
    <div class="responsive-table">
      
      <h2 class="card-header">Uw medicijnen</h2>
    <b-table fixed responsive="true" striped hover :items="medicineList" :fields=fields>
      <template v-slot:cell(info)="row">
         <b-button size="sm" variant="info" @click="info(row.item, $event.target)" class="btn btn-primary">
           Inspecteer 
        </b-button>
        
      </template>
      <template v-slot:cell(delete)="row">

        <b-button class="btn" variant="danger" size="sm" @click="showMsgBoxTwo(row.item, $event.target)">
          Verwijder 
        </b-button>
      </template>
        
    </b-table>
    </div>
</template>

<script>

//import Medicine from "./Medicine";
import Vue from 'vue';
import VueResizeText from 'vue-resize-text';
Vue.use(VueResizeText);

export default {
  name: "MedicineList",
  props: ["medicineList"],
  components: {
    //Medicine,
  },
  data(){
    return{
      fields:[
        {key: "name", label: "Naam"},
        {key: "description", label: "Beschrijving"},
        {key: "info", label: "Inspecteer medicijn"},
        {key: "delete", label: "Verwijder medicijn"}

      ]
    }
  },
  methods:{
    info: function(obj){
      this.$emit("inspect-medicine", obj)
    },
    deleteMed: function(obj){
      this.$emit("del-medicine", obj);
    },
    showMsgBoxTwo: function(obj) {
        this.boxTwo = ''
        this.$bvModal.msgBoxConfirm('Weet u zeker dat u: ' + obj.name + ' uit uw medicijnlijst wilt verwijderen?', {
          title: 'Bevestiging',
          size: 'sm',
          buttonSize: 'sm',
          okVariant: 'danger',
          okTitle: 'Ja',
          cancelVariant: 'primary',
          cancelTitle: 'Nee',
          footerClass: 'p-2',
          hideHeaderClose: false,
          centered: true
        })
          .then(value => {
            this.boxTwo = value
            if (value == true) {
              this.deleteMed(obj)
            }
          })
          .catch(err=>console.log(err))
      }
  }

};
</script>

<style >

</style>