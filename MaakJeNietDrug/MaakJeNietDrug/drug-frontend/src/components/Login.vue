<template>
    <div>
        <b-form
        @submit="Inloggen"
        @reset="Reset"
        v-if="show">
        <b-form-group
        id="input-group-1"
        label="Gebruikersnaam:"
        label-for="input-log-gebruikersnaam"
        description="Voer hier uw gebruikersnaam in"
        class="ml-5 mr-5">
        <b-form-input
        id="input-log-gebruikersnaam"
        v-model="account.gebruikersnaam"
        type="text"
        required
        placeholder="MoederNatuur123"
        >
        </b-form-input>
        
        </b-form-group>
        <b-form-group
        id="input-group-2"
        label="Wachtwoord:"
        label-for="input-log-wachtwoord"
        description="Voer hier uw wachtwoord in"
        class="ml-5 mr-5">
        <b-form-input
        id="input-log-wachtwoord"
        v-model="account.wachtwoord"
        type="password"
        required
        placeholder="***********"
        >

        </b-form-input>
        </b-form-group>
        <b-button type="submit" variant="primary" class="mr-2">Login</b-button>
        <b-button type="reset" variant="danger" class="ml-2">Reset</b-button>
        </b-form>
    </div>
</template>

<script>
export default {
    data(){
        return{
            account: {
                gebruikersnaam: "",
                wachtwoord: ""
            }, 
            show: true
        }
    },
    methods:{
        Inloggen(e){
            e.preventDefault();
            //API shit
        },
        Reset(e){
            e.preventDefault();
            this.account.gebruikersnaam = "";
            this.account.wachtwoord ="";
            this.show=false;
            this.$nextTick(()=>{this.show = true});
        }

    }
}
</script>

<style scoped>

</style>