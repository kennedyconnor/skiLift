<template>
  <div class="rideForm col-4 offset-2">
    <h3>Driver</h3>
    <h5>Pick up passengers</h5>
    <form @submit.prevent="createRide">
      <div class="form-group">
        <label>Destination (Idaho)</label>
        <select class="form-control" id="RideFormDestinationSelect" v-model="newRide.destination">
          <option>Bogus Basin</option>
          <option>Tamarack</option>
          <option>Brundage</option>
          <option>Sun Valley</option>
        </select>
        <input type="number" v-model="newRide.capacity" placeholder="Passenger Capacity">
        <input type="time" v-model="newRide.departTime" placeholder="Departure Time">
      </div>
      <button type="submit" class="btn btn-primary">Submit</button>
    </form>
  </div>
</template>

<script>
  export default {
    name: "",
    props: [],
    data() {
      return {
        newRide: {
          name: "",
          destination: "",
          capacity: "",
          departTime: ""
        }
      }
    },
    computed: {},
    methods: {
      createRide() {
        this.newRide.name = this.$store.state.user.username
        this.$store.dispatch("createRide", this.newRide)
      }
    },
    components: {}
  }
</script>

<style>

</style>