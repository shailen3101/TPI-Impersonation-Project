<template>
	<v-jsoneditor
		v-model="json"
		:options="options"
		:plus="false"
		height="400px"
		@error="onError"
	>
	</v-jsoneditor>
</template>

<script>
	import VJsoneditor from 'v-jsoneditor/src/index'

	export default {
		name: 'app',
		components: {
			VJsoneditor,
		},
		data() {
			return {
				json: {
					hello: 'vue',
				},
			}
		},
		methods: {
			onError() {
				console.log('error')
			},
		},
	}
</script>
