<template>
	<v-row align="center" justify="center">
		<v-col cols="12">
			<v-card>
				<v-card-title class="green--text">{{ commandInfo.name }}</v-card-title>
				<v-card-subtitle class="black--text"
					>Enter the JSON and hit send to get a Response</v-card-subtitle
				>
				<v-col>
					<app-json-editor></app-json-editor>
				</v-col>
				<v-col align="right">
					<v-btn color="blue">Send Request</v-btn>
				</v-col>
			</v-card>
		</v-col>
	</v-row>
</template>

<script>
	import AppJsonEditor from './JsonEditor.vue'

	export default {
		props: {
			isSelected: Boolean,
		},
		data: () => ({
			commandInfo: {},
		}),
		components: {
			AppJsonEditor,
		},
		watch: {
			$route() {
				this.commandInfo = {
					...this.$store.getters.getCommand(this.$route.params.command),
				}
				console.log(this.commandInfo)
			},
		},
		created() {
			this.commandInfo = {
				...this.$store.getters.getCommand(this.$route.params.command),
			}
			console.log(this.commandInfo)
		},
	}
</script>
