<template>
  <div>
    <b-card
      :img-src="dragon.Image"
      img-alt="Image"
      img-top
      tag="article"
      style="max-width: 20rem;"
      class="mb-2 dragon-card"
      @click="modalShow = !modalShow"
    >
      <b-card-title>{{dragon.Name}}</b-card-title>
      <b-card-text>Some quick example text to build on the card title and make up the bulk of the card's content.</b-card-text>
      <b-card-footer>Type: {{dragon.Type}}</b-card-footer>
    </b-card>
    <b-modal v-model="modalShow" title="Details" hide-footer="true">
      <b-img :src="dragon.Image" fluid-grow alt="Responsive image"></b-img>
      <b-list-group>
        <b-list-group-item>
          Name:
          <span class="float-right">{{dragon.Name}}</span>
        </b-list-group-item>
        <b-list-group-item>
          Category:
          <span class="float-right">{{dragon.Category}}</span>
        </b-list-group-item>
        <b-list-group-item>
          Type:
          <span class="float-right">{{dragon.Type}}</span>
        </b-list-group-item>
        <b-list-group-item>
          Loot:
          <span class="float-right">{{dragon.Loot}}</span>
        </b-list-group-item>
      </b-list-group>
    </b-modal>
  </div>
</template>

<script>
export default {
  props: ["dragon"],
  data() {
    return {
      modalShow: false
    };
  }
};
</script>

<style scoped>
.dragon-card {
  margin: 1.5rem;
}
</style>