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
            Connor: { lat: 43.6150142, lng: -116.2367955 },
            map: {}
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

         let marker = new google.maps.Marker({
            position: this.Connor,
            map: this.map,
            title: "Connor Kennedy",
            icon: {
               url: "ski.png", // url
               scaledSize: new google.maps.Size(30, 30),
            }

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