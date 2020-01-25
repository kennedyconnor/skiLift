<template>
   <div class="Map">
      <div id="googleMap">

      </div>
   </div>
</template>

<script>
   export default {
      name: "GoogleMap",
      props: [],
      data() {
         return {
            gMap: "",
         }
      },
      computed: {},
      methods: {},
      components: {},
      mounted() {
         this.map = new google.maps.Map(document.getElementById('googleMap'), {
            center: { lat: 43.6150, lng: -116.2023 },
            scrollwheel: false,
            zoom: 12
         })
      }
   }
</script>

<style>
   #googleMap {
      height: 500px;
      width: 100%;
   }
</style>