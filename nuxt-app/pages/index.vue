<template>
  <div class="container">Welcome Dragon finder (with kittens images!?)</div>
</template>

<script>
export default {
  head() {
    return {
      title: "Home page",
      meta: [
        // hid is used as unique identifier. Do not use `vmid` for it as it will not work
        {
          hid: "description1",
          name: "description1",
          content: "My custom description1"
        }
      ]
    };
  }
};
</script>

<style>
.container {
  margin: 0 auto;
  min-height: calc(100vh - 96px);
  display: flex;
  justify-content: center;
  align-items: center;
  text-align: center;
  font-size: 25px;
}
</style>
