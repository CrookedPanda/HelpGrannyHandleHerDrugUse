<template>
  <div>
    <b-form
      @submit="Inloggen"
      @reset="Reset"
      v-if="show"
    :class="[`${windowWidth2 > 800 ? 'special__class2':'normal__class2'}`]"
    >
      <b-form-group
        id="input-group-1"
        label="Gebruikersnaam:"
        label-for="input-log-gebruikersnaam"
        description="Voer hier uw gebruikersnaam in"
      >
        <b-form-input
          id="input-log-gebruikersnaam"
          v-model="gebruikersnaam"
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
      >
        <b-form-input
          id="input-log-wachtwoord"
          v-model="wachtwoord"
          type="password"
          required
          placeholder="***********"
        >
        </b-form-input>
      </b-form-group>
      <b-button type="submit" variant="primary" class="mr-2">Login</b-button>
      <b-button type="reset" variant="danger" class="ml-2">Reset</b-button>
      <div class="form-group mt-5">
    <label class="form__label">Validation status:</label>
    <ul class="list__ul">
      <li v-if="!$v.gebruikersnaam.required"> Gebruikersnaam is verplicht! </li>
      <li v-if="!$v.gebruikersnaam.minLength">Gebruikersnaam moet minimaal {{$v.gebruikersnaam.$params.minLength.min}} karakters zijn!</li>
      <li v-if="!$v.gebruikersnaam.maxLength">Gebruikersnaam mag maximaal {{$v.gebruikersnaam.$params.maxLength.max}} karakters zijn!</li>
      <li v-if="!$v.wachtwoord.required">Wachtwoord is verplicht!</li>
      <li v-if="!$v.wachtwoord.minLength">Wachtwoord moet minimaal {{$v.wachtwoord.$params.minLength.min}} karakters zijn!</li>
      <li v-if="!$v.wachtwoord.maxLength">Wachtwoord mag maximaal {{$v.wachtwoord.$params.maxLength.max}} karakters zijn!</li>
      <li v-if="$v.$invalid"> <kbd>Ongeldige invoer</kbd></li>
      <li v-else>All fine.</li>
    </ul>
  </div>
    </b-form>
  </div>
</template>

<script>
import Vue from "vue";
import Vuelidate from "vuelidate";
import { required, minLength, maxLength } from "vuelidate/lib/validators";
Vue.use(Vuelidate);
export default {
  data() {
    return {
        gebruikersnaam: "",
        wachtwoord: "",
      show: true,
      windowWidth2: window.innerWidth,
    };
  },
  methods: {
    Inloggen(e) {
      const Acc = {
        gebruikersnaam: this.gebruikersnaam,
        wachtwoord: this.wachtwoord
      }
      this.$v.$touch()
      if(this.$v.$invalid){
        e.preventDefault();
        alert("Controleer uw gegevens, iets klopt niet");
      }
      else{
        this.$emit("log-in", Acc);
      }
    },
    Reset(e) {
      e.preventDefault();
      this.account.gebruikersnaam = "";
      this.account.wachtwoord = "";
      this.show = false;
      this.$nextTick(() => {
        this.show = true;
      });
    },
  },
  validations: {
    gebruikersnaam:{
      required,
      minLength: minLength(4),
      maxLength: maxLength(24)
    },
    wachtwoord:{
      required,
      minLength: minLength(4),
      maxLength: maxLength(24),
    }
  },
 mounted() {
    window.onresize = () => {
      this.windowWidth2 = window.innerWidth;
    };
  },
  updated(){
     window.onresize = () => {
      this.windowWidth2 = window.innerWidth;
    };
  }
};
</script>

<style >
.special__class2{
    margin-left: 25%;
    margin-right: 25%;
}
.normal__class2{
    margin-left: 5%;
    margin-right: 5%;
}
</style>