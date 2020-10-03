<template>
    <div>
    <b-table striped hover :items="medicineList" :fields=fields>
      <template v-slot:cell(btn)="row">
         <b-button size="sm" @click="info(row.item, $event.target)" class="mr-1">
          Info modal
        </b-button>
        <b-button size="sm" @click="showMsgBoxTwo(row.item, $event.target)" class="mr-1">
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
        {key: "name", label: "name"},
        {key: "description", label: "description"},
        {key: "btn", label: "btn"}

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
        this.$bvModal.msgBoxConfirm('Are you sure you want to delete ' + obj.name + ' from your medicine List?', {
          title: 'Please Confirm',
          size: 'sm',
          buttonSize: 'sm',
          okVariant: 'danger',
          okTitle: 'YES',
          cancelTitle: 'NO',
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