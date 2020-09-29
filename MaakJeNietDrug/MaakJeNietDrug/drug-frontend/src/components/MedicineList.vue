<template>
    <div>
    <b-table striped hover :items="medicineList" :fields=fields>
      <template v-slot:cell(btn)="row">
         <b-button size="sm" @click="info(row.item, row.index, $event.target)" class="mr-1">
          Info modal
        </b-button>
         <b-button size="sm" @click="deleteMed(row.item, row.index, $event.target)" class="mr-1">
            Delete
        </b-button>
      </template>
        
    </b-table>
    </div>
</template>

<script>

//import Medicine from "./Medicine";

export default {
  name: "MedicineList",
  props: ["medicineList"],
  components: {
    //Medicine,
  },
  data(){
    return{
      fields:[
        {key: "id", label: "id"},
        {key: "name", label: "naaame"},
        {key: "btn", label: "btn"}
      ]
    }
  },
  methods:{
    info: function(obj){
      console.log(obj.id);
    },
    deleteMed: function(obj, index){
    this.medicineList.splice(index, 1);
    }
    
  }

};
</script>

<style >

</style>