<template>
  <div>
    {{greet}} {{name}}
    <div v-text="channel"></div>
    <div v-html="channel2"></div>
    <div v-html="hack"></div>
    <h2 v-bind:id="idBind">Id binding</h2>
    <button v-bind:disabled="disabledBind">Button binding</button>
  </div>
</template>

<script>
  export default {
    name: 'App',
    data() {
      return {
        greet: "Hello",
        name: "Bot",
        channel: "Coding",
        channel2: "<b>Coding<b>", 
        hack: `<a href="#" onclick="alert('You have been hacked!')">Click me</a>`,
        idBind: "Binding",
        disabledBind: true,
      }
    }
  }
</script>

<style> 
  #app {
    font-family: Avenir, Helvetica, Arial, sans-serif;
    -webkit-font-smoothing: antialiased;
    -moz-osx-font-smoothing: grayscale;
    text-align: center;
    color: #2c3e50;
    margin-top: 60px;
  }
</style>
