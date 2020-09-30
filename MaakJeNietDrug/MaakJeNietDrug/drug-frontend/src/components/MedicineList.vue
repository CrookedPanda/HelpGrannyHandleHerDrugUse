<template>
    <div>
    <b-table striped hover :items="medicineList" :fields=fields>
      <template v-slot:cell(btn)="row">
         <b-button size="sm" @click="info(row.item, row.index, $event.target)" class="mr-1">
          Info modal
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
        {key: "title", label: "title"},
        {key: "description", label: "description"},
        {key: "btn", label: "btn"}

      ]
    }
  },
  methods:{
    info: function(obj){
      console.log(obj.id);
    }
  }

};
</script>

<style >

</style>