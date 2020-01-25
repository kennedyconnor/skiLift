<template>
  <div class="home ">
    <h3>SkiLift</h3>
    <h6>Easy ridesharing to your local mountain!</h6>
    <GoogleMap />
    Icons made by <a href="https://www.flaticon.com/authors/freepik" title="Freepik">Freepik</a> from <a
      href="https://www.flaticon.com/" title="Flaticon"> www.flaticon.com</a>
  </div>
</template>


<script>
  import GoogleMap from "@/components/GoogleMap.vue"
  export default {
    name: "home",
    props: [],
    data() {
      return {}
    },
    computed: {},
    methods: {},
    components: { GoogleMap }
  }
</script>

<style>

</style>