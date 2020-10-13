 <template>
  <div>
    <b-form @submit="Registreren" @reset="Reset" v-if="show">
      <b-form-group
        id="input-group-1"
        label="Gebruikersnaam:"
        label-for="input-gebruikersnaam"
        description="Voer hier een gebruikersnaam in"
        style="margin-left:25%; margin-right:25%"
      >
        <b-form-input
          id="input-gebruikersnaam"
          v-model="account.gebruikersnaam"
          type="text"
          required
          placeholder="PoppendePater72"
        >
        </b-form-input>
      </b-form-group>
      <b-form-group
        id="input-group-2"
        label="E-mail:"
        label-for="input-email"
        description="Voer hier uw Email in"
        style="margin-left:25%; margin-right:25%"
      >
        <b-form-input
          id="input-email"
          v-model="account.email"
          type="email"
          required
          placeholder="PaterNooitGenoeg@christerlijkgedoe.com"
        >
        </b-form-input>
      </b-form-group>
      <b-form-group
        id="input-group-3"
        label="Wachtwoord:"
        label-for="input-wachtwoord"
        description="Voer hier uw wachtwoord in"
        style="margin-left:25%; margin-right:25%"
      >
        <b-form-input
          id="input-wachtwoord"
          v-model="account.wachtwoord"
          type="password"
          required
          placeholder="***********"
        >
        </b-form-input>
      </b-form-group>
            <b-form-group
        id="input-group-4"
        label="Herhaal wachtwoord:"
        label-for="input-wachtwoord2"
        description="Voer hier uw wachtwoord nogmaals in"
        style="margin-left:25%; margin-right:25%"
      >
        <b-form-input
          id="input-wachtwoord"
          v-model="account.wachtwoord2"
          type="password"
          required
          placeholder="***********"
        >
        </b-form-input>
      </b-form-group>
      <b-button type="submit" variant="primary" class="mr-2 btn">Registreer</b-button>
      <b-button type="reset" variant="danger" class="ml-2 btn">Reset</b-button>
    </b-form>
  </div>
</template>

<script>
export default {
  data() {
    return {
      account: {
        gebruikersnaam: "",
        wachtwoord: "",
        wachtwoord2: "",
        email: ""
      },
      show: true,
    };
  },
  methods: {
    Registreren(e) {
      e.preventDefault();
      //API shit
    },
    Reset(e) {
      e.preventDefault();
      this.account.gebruikersnaam = "";
      this.account.wachtwoord = "";
      this.account.wachtwoord2 = "";
      this.account.email = "";
      this.show = false;
      this.$nextTick(() => {
        this.show = true;
      });
    },
  },
};
</script>

<style scoped>
</style>