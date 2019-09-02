<template>
  <div>
    <b-card-group columns>
      <Dragon v-for="(dragon, index) in dragons" v-bind:key="index" v-bind:dragon="dragon" />
    </b-card-group>
  </div>
</template>

<script>
import Dragon from "~/components/dragon.vue";
import axios from "axios";

export default {
  components: {
    Dragon
  },
  async asyncData({ params }) {
    let { data } = await axios.get(
      `http://lightningtalkapi.azurewebsites.net/api/dragons`
    );
    return { dragons: data };
  },
  head() {
    return {
      title: "List page",
      meta: [
        // hid is used as unique identifier. Do not use `vmid` for it as it will not work
        {
          hid: "description2",
          name: "description2",
          content: "My custom description2"
        }
      ]
    };
  }
};
</script>

<style scoped>
.card-columns {
  column-count: 5;
}
</style>
