S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 18189
Date: 2017-06-13 14:09:15+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 18189, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x0000470d
r2   = 0x00000006, r3   = 0xb410b4c0
r4   = 0x00000002, r5   = 0xb410b000
r6   = 0xb680509c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb5f33708
r10  = 0xb89fe270, fp   = 0x00000000
ip   = 0x00000000, sp   = 0xbe9a2e34
lr   = 0xb66fbf18, pc   = 0xb66fab84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:     48268 KB
Buffers:     64568 KB
Cached:     239408 KB
VmPeak:     118356 KB
VmSize:     114992 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       32040 KB
VmRSS:       28232 KB
VmData:      36540 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35860 KB
VmPTE:          90 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 18189 TID = 18189
18189 18192 18514 18536 

Maps Information
b02b4000 b0ab3000 rw-p [stack:18536]
b1ae9000 b1afa000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b1b0a000 b1b0f000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b1bd4000 b1bdc000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1bed000 b1bee000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1bfe000 b1c12000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1c26000 b1c27000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c37000 b1c3a000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c4b000 b1c4c000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c5c000 b1c5e000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c6e000 b1c70000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c80000 b1c90000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1ca0000 b1cac000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1cbe000 b24bd000 rw-p [stack:18514]
b27ee000 b27f5000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2808000 b280e000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b281e000 b284e000 r-xp /opt/usr/apps/org.example.client/bin/client
b2997000 b2a7a000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2ab1000 b2ad9000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2aeb000 b32ea000 rw-p [stack:18192]
b32ea000 b32ec000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32fc000 b3306000 r-xp /lib/libnss_files-2.20-2014.11.so
b3317000 b3320000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3331000 b3342000 r-xp /lib/libnsl-2.20-2014.11.so
b3355000 b335b000 r-xp /lib/libnss_compat-2.20-2014.11.so
b336c000 b336d000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3395000 b339c000 r-xp /usr/lib/libminizip.so.1.0.0
b33ac000 b33b1000 r-xp /usr/lib/libstorage.so.0.1
b33c1000 b3420000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3436000 b344a000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b345a000 b349e000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b34ae000 b34b6000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b34c6000 b34f6000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3509000 b35c2000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b35d6000 b3629000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b363a000 b3655000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3665000 b3726000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3739000 b3749000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3759000 b3766000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3777000 b377e000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b378e000 b37cf000 r-xp /usr/lib/libmdm.so.1.2.12
b37df000 b37e7000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37f6000 b3806000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3827000 b3887000 r-xp /usr/lib/libasound.so.2.0.0
b3899000 b389c000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b38ac000 b38af000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b38bf000 b38c4000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b38d4000 b38d5000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38e5000 b38f0000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3904000 b390b000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b391b000 b3921000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3931000 b3936000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3946000 b3961000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3971000 b3978000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3988000 b398b000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b399c000 b39ca000 r-xp /usr/lib/libidn.so.11.5.44
b39da000 b39f0000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3a01000 b3a0b000 r-xp /usr/lib/libcares.so.2.1.0
b3a1b000 b3a25000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a35000 b3a37000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a47000 b3a48000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a58000 b3a5c000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a6d000 b3a95000 r-xp /usr/lib/libui-extension.so.0.1.0
b3aa6000 b3acf000 r-xp /usr/lib/libturbojpeg.so
b3aef000 b3af5000 r-xp /usr/lib/libgif.so.4.1.6
b3b05000 b3b4b000 r-xp /usr/lib/libcurl.so.4.3.0
b3b5c000 b3b7d000 r-xp /usr/lib/libexif.so.12.3.3
b3b98000 b3bad000 r-xp /usr/lib/libtts.so
b3bbe000 b3bc6000 r-xp /usr/lib/libfeedback.so.0.1.4
b3bd6000 b3c9c000 r-xp /usr/lib/libdali-core.so.0.0.0
b3cbc000 b3db4000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3dd3000 b3ea1000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3eb8000 b3eba000 r-xp /usr/lib/libboost_system.so.1.51.0
b3eca000 b3ed0000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3ee0000 b3f03000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3f14000 b3f16000 r-xp /usr/lib/libappsvc.so.0.1.0
b3f26000 b3f28000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f39000 b3f3e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f55000 b3f57000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f67000 b3f6e000 r-xp /usr/lib/libsensord-share.so
b3f7e000 b3f96000 r-xp /usr/lib/libsensor.so.1.1.0
b3fa7000 b3faa000 r-xp /usr/lib/libXv.so.1.0.0
b3fba000 b3fbf000 r-xp /usr/lib/libutilX.so.1.1.0
b3fcf000 b3fd4000 r-xp /usr/lib/libappcore-common.so.1.1
b3fe4000 b3feb000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3ffe000 b4002000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4013000 b40f1000 r-xp /usr/lib/libCOREGL.so.4.0
b4111000 b4114000 r-xp /usr/lib/libuuid.so.1.3.0
b4124000 b413b000 r-xp /usr/lib/libblkid.so.1.1.0
b414c000 b414e000 r-xp /usr/lib/libXau.so.6.0.0
b415e000 b41a5000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b41b7000 b41bd000 r-xp /usr/lib/libjson-c.so.2.0.1
b41ce000 b41d2000 r-xp /usr/lib/libogg.so.0.7.1
b41e2000 b4204000 r-xp /usr/lib/libvorbis.so.0.4.3
b4214000 b42f8000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4314000 b4317000 r-xp /usr/lib/libEGL.so.1.4
b4328000 b432e000 r-xp /usr/lib/libxcb-render.so.0.0.0
b433e000 b4340000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4350000 b435d000 r-xp /usr/lib/libGLESv2.so.2.0
b436e000 b43d0000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43e5000 b43fd000 r-xp /usr/lib/libmount.so.1.1.0
b440f000 b4423000 r-xp /usr/lib/libxcb.so.1.1.0
b4433000 b443a000 r-xp /lib/libcrypt-2.20-2014.11.so
b4472000 b4474000 r-xp /usr/lib/libiri.so
b4484000 b448f000 r-xp /usr/lib/libgpg-error.so.0.15.0
b44a0000 b44d6000 r-xp /usr/lib/libpulse.so.0.16.2
b44e7000 b452a000 r-xp /usr/lib/libsndfile.so.1.0.25
b453f000 b4554000 r-xp /lib/libexpat.so.1.5.2
b4566000 b4624000 r-xp /usr/lib/libcairo.so.2.11200.14
b4638000 b4640000 r-xp /usr/lib/libdrm.so.2.4.0
b4650000 b4653000 r-xp /usr/lib/libdri2.so.0.0.0
b4663000 b46b1000 r-xp /usr/lib/libssl.so.1.0.0
b46c6000 b46d2000 r-xp /usr/lib/libeeze.so.1.13.0
b46e3000 b46ec000 r-xp /usr/lib/libethumb.so.1.13.0
b46fc000 b46ff000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b470f000 b48c6000 r-xp /usr/lib/libcrypto.so.1.0.0
b56b1000 b56ba000 r-xp /usr/lib/libXi.so.6.1.0
b56ca000 b56cc000 r-xp /usr/lib/libXgesture.so.7.0.0
b56dc000 b56e0000 r-xp /usr/lib/libXtst.so.6.1.0
b56f0000 b56f6000 r-xp /usr/lib/libXrender.so.1.3.0
b5706000 b570c000 r-xp /usr/lib/libXrandr.so.2.2.0
b571c000 b571e000 r-xp /usr/lib/libXinerama.so.1.0.0
b572f000 b5732000 r-xp /usr/lib/libXfixes.so.3.1.0
b5742000 b574d000 r-xp /usr/lib/libXext.so.6.4.0
b575d000 b575f000 r-xp /usr/lib/libXdamage.so.1.1.0
b576f000 b5771000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5781000 b5863000 r-xp /usr/lib/libX11.so.6.3.0
b5877000 b587e000 r-xp /usr/lib/libXcursor.so.1.0.2
b588e000 b58a6000 r-xp /usr/lib/libudev.so.1.6.0
b58a8000 b58ab000 r-xp /lib/libattr.so.1.1.0
b58bb000 b58db000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58dc000 b58e1000 r-xp /usr/lib/libffi.so.6.0.2
b58f2000 b590a000 r-xp /lib/libz.so.1.2.8
b591a000 b591c000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b592c000 b5a01000 r-xp /usr/lib/libxml2.so.2.9.2
b5a16000 b5ab1000 r-xp /usr/lib/libstdc++.so.6.0.20
b5acd000 b5ad0000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5ae0000 b5af9000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b0a000 b5b1b000 r-xp /lib/libresolv-2.20-2014.11.so
b5b2f000 b5ba9000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bbe000 b5bc0000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bd0000 b5bd7000 r-xp /usr/lib/libembryo.so.1.13.0
b5be7000 b5bf1000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5c02000 b5c1a000 r-xp /usr/lib/libpng12.so.0.50.0
b5c2b000 b5c4e000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c6f000 b5c83000 r-xp /usr/lib/libector.so.1.13.0
b5c94000 b5cac000 r-xp /usr/lib/liblua-5.1.so
b5cbd000 b5d14000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d28000 b5d50000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d61000 b5d74000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d85000 b5dbf000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5dd0000 b5dde000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5dee000 b5df6000 r-xp /usr/lib/libtbm.so.1.0.0
b5e06000 b5e13000 r-xp /usr/lib/libeio.so.1.13.0
b5e23000 b5e25000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e35000 b5e3a000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e4a000 b5e61000 r-xp /usr/lib/libefreet.so.1.13.0
b5e73000 b5e93000 r-xp /usr/lib/libeldbus.so.1.13.0
b5ea3000 b5ec3000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ec5000 b5ecb000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5edb000 b5eec000 r-xp /usr/lib/libemotion.so.1.13.0
b5efd000 b5f04000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f14000 b5f23000 r-xp /usr/lib/libeo.so.1.13.0
b5f34000 b5f46000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f57000 b5f5c000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f6c000 b5f85000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f95000 b5fb2000 r-xp /usr/lib/libeet.so.1.13.0
b5fcb000 b6013000 r-xp /usr/lib/libeina.so.1.13.0
b6024000 b6034000 r-xp /usr/lib/libefl.so.1.13.0
b6045000 b612a000 r-xp /usr/lib/libicuuc.so.51.1
b6147000 b6287000 r-xp /usr/lib/libicui18n.so.51.1
b629e000 b62d6000 r-xp /usr/lib/libecore_x.so.1.13.0
b62e8000 b62eb000 r-xp /lib/libcap.so.2.21
b62fb000 b6324000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6335000 b633c000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b634e000 b6385000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6396000 b6481000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6494000 b650d000 r-xp /usr/lib/libsqlite3.so.0.8.6
b651f000 b6524000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6534000 b653e000 r-xp /usr/lib/libvconf.so.0.2.45
b654e000 b6550000 r-xp /usr/lib/libvasum.so.0.3.1
b6560000 b6562000 r-xp /usr/lib/libttrace.so.1.1
b6572000 b6575000 r-xp /usr/lib/libiniparser.so.0
b6585000 b65ab000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65bb000 b65c0000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65d1000 b65e8000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65f9000 b6664000 r-xp /lib/libm-2.20-2014.11.so
b6675000 b667b000 r-xp /lib/librt-2.20-2014.11.so
b668c000 b6699000 r-xp /usr/lib/libunwind.so.8.0.1
b66cf000 b67f3000 r-xp /lib/libc-2.20-2014.11.so
b6808000 b6821000 r-xp /lib/libgcc_s-4.9.so.1
b6831000 b6913000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6924000 b694e000 r-xp /usr/lib/libdbus-1.so.3.8.12
b695f000 b699b000 r-xp /usr/lib/libsystemd.so.0.4.0
b699d000 b6a20000 r-xp /usr/lib/libedje.so.1.13.0
b6a33000 b6a51000 r-xp /usr/lib/libecore.so.1.13.0
b6a71000 b6bf8000 r-xp /usr/lib/libevas.so.1.13.0
b6c2d000 b6c41000 r-xp /lib/libpthread-2.20-2014.11.so
b6c55000 b6e89000 r-xp /usr/lib/libelementary.so.1.13.0
b6eb8000 b6ebc000 r-xp /usr/lib/libsmack.so.1.0.0
b6ecc000 b6ed3000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ee3000 b6ee5000 r-xp /usr/lib/libdlog.so.0.0.0
b6ef5000 b6ef8000 r-xp /usr/lib/libbundle.so.0.1.22
b6f08000 b6f0a000 r-xp /lib/libdl-2.20-2014.11.so
b6f1b000 b6f33000 r-xp /usr/lib/libaul.so.0.1.0
b6f47000 b6f4c000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f5d000 b6f6a000 r-xp /usr/lib/liblptcp.so
b6f7c000 b6f80000 r-xp /usr/lib/libsys-assert.so
b6f91000 b6fb1000 r-xp /lib/ld-2.20-2014.11.so
b6fc2000 b6fc7000 r-xp /usr/bin/launchpad-loader
b8697000 b8a2a000 rw-p [heap]
be983000 be9a4000 rw-p [stack]
End of Maps Information

Callstack Information (PID:18189)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb66fab84) [/lib/libc.so.6] + 0x2bb84
End of Call Stack

Package Information
Package Name: org.example.client
Package ID : org.example.client
Version: 1.0.0
Package Type: tpk
App Name: client
App ID: org.example.client
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
quest_handler(906) > __request_handler: 33
06-13 14:09:02.036+0900 I/APP_CORE(18189): appcore-efl.c: __do_app(514) > [APP 18189] Event: RESUME State: PAUSED
06-13 14:09:02.036+0900 I/CAPI_APPFW_APPLICATION(18189): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 14:09:02.036+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 14:09:02.036+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 14:09:02.036+0900 I/CAPI_APPFW_APPLICATION(18264): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
06-13 14:09:02.036+0900 E/TASK_MGR_LITE(18264): recent_app_viewer.c: destroy_recent_app_viewer(1583) > destroy_recent_app_viewer
06-13 14:09:02.106+0900 E/TASK_MGR_LITE(18264): recent_apps.c: list_destroy(376) > (NULL == list) -> list_destroy() return
06-13 14:09:02.126+0900 E/APP_CORE(18264): appcore.c: appcore_flush_memory(793) > Appcore not initialized
06-13 14:09:02.126+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is e0[0m
06-13 14:09:02.136+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is a0[0m
06-13 14:09:02.136+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 30[0m
06-13 14:09:02.136+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 20[0m
06-13 14:09:02.136+0900 W/CANDIDATE(  804): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
06-13 14:09:02.136+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 10[0m
06-13 14:09:02.146+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
06-13 14:09:02.156+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:02.156+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
06-13 14:09:02.156+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:02.156+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:02.156+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:02.156+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:02.156+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:02.156+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:02.156+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:02.156+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:02.156+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
06-13 14:09:02.166+0900 E/ISE_MULTI(  804): ise.cpp: update_keyboard_geometry(598) > [0;31mg_main_window_rect.height 577  rect->height : 577[0m
06-13 14:09:02.166+0900 I/SWIFTKEY(  713): swiftkey_engine.cpp: IME_Generate_prediction(1498) > [0;36mGen prediction[0m
06-13 14:09:02.166+0900 W/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: refresh_lookup_table(4124) > [0;33mDo not need to insert.[0m
06-13 14:09:02.176+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is d0[0m
06-13 14:09:02.206+0900 I/MALI    (18264): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=18264   close drm_fd=30 
06-13 14:09:02.246+0900 I/ISE_MULTI(  804): privatekeys.cpp: ise_update_Sym_private_key_for_lang(2283) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
06-13 14:09:02.336+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: MEM_FLUSH State: PAUSED
06-13 14:09:02.346+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(18189) status(0)
06-13 14:09:02.386+0900 I/ISE_MULTI(  804): isemain.cpp: slot_set_caps_mode(1028) > [0;36m[hidden state:false] mode=1[0m
06-13 14:09:02.386+0900 W/CANDIDATE(  804): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
06-13 14:09:02.386+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
06-13 14:09:02.396+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:02.396+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
06-13 14:09:02.396+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:02.396+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:02.396+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:02.396+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:02.396+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:02.396+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:02.396+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:02.396+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:02.396+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
06-13 14:09:02.406+0900 I/ISE_MULTI(  804): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=0[0m
06-13 14:09:02.406+0900 W/CANDIDATE(  804): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
06-13 14:09:02.406+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
06-13 14:09:02.406+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:02.406+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
06-13 14:09:02.406+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:02.406+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:02.416+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:02.416+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:02.416+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:02.416+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:02.416+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:02.416+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:02.416+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
06-13 14:09:02.456+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 18264 pgid = 18264
06-13 14:09:02.456+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(18264)
06-13 14:09:02.496+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 14:09:02.496+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 14:09:02.496+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 14:09:02.496+0900 I/Tizen::App( 1175): (243) > App[com.samsung.task-mgr] pid[18264] terminate event is forwarded
06-13 14:09:02.496+0900 I/Tizen::System( 1175): (256) > osp.accessorymanager.service provider is found.
06-13 14:09:02.496+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [com.samsung.task-mgr, 18264, ]
06-13 14:09:02.496+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 14:09:02.496+0900 I/Tizen::App( 1175): (506) > TerminatedApp(com.samsung.task-mgr)
06-13 14:09:02.496+0900 I/Tizen::App( 1175): (512) > Not registered pid(18264)
06-13 14:09:02.496+0900 I/Tizen::System( 1175): (246) > Terminated app [com.samsung.task-mgr]
06-13 14:09:02.496+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 14:09:02.496+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 18264
06-13 14:09:02.496+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 18264
06-13 14:09:02.496+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 18264
06-13 14:09:02.506+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1845
06-13 14:09:02.516+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 14:09:02.516+0900 I/Tizen::App( 1175): (782) > Finished invoking application event listener for com.samsung.task-mgr, 18264.
06-13 14:09:02.526+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(804) status(3)
06-13 14:09:02.906+0900 I/UXT     (18529): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-13 14:09:02.946+0900 E/TBM     (18529): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 14:09:02.946+0900 I/MALI    (18529): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=18529   open drm_fd=30 
06-13 14:09:03.067+0900 E/EFL     (18529): edje<18529> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:09:03.067+0900 E/EFL     (18529): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:09:03.067+0900 E/EFL     (18529): edje<18529> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:09:03.067+0900 E/EFL     (18529): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:09:03.067+0900 E/EFL     (18529): edje<18529> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:09:03.067+0900 E/EFL     (18529): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:09:03.507+0900 E/EFL     (18189): ecore_x<18189> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17529706
06-13 14:09:03.507+0900 I/MY_LOG  (18189): Button pressed
06-13 14:09:03.577+0900 E/EFL     (18189): ecore_x<18189> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17529783
06-13 14:09:03.587+0900 I/ISE_MULTI(  804): isemain.cpp: slot_reset_ise_input_context(1280) > [0;36m[hidden state:false][0m
06-13 14:09:03.587+0900 I/SWIFTKEY(  713): swiftkey_engine.cpp: IME_Learn_sentence(2373) > [0;36mDLM write[0m
06-13 14:09:03.587+0900 E/VCONF   (18189): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
06-13 14:09:03.587+0900 E/VCONF   (18189): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
06-13 14:09:03.587+0900 E/VCONF   (18189): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
06-13 14:09:03.587+0900 E/VCONF   (18189): vconf.c: vconf_get_bool(2729) > vconf_get_bool(18189) : db/ise/keysound error
06-13 14:09:03.597+0900 E/VCONF   (18189): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
06-13 14:09:03.597+0900 E/VCONF   (18189): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
06-13 14:09:03.647+0900 I/MY_LOG  (18189): Button unpressed
06-13 14:09:03.667+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x3200002 FAILED!
06-13 14:09:03.687+0900 D/basicui (18189): successed to load edc file
06-13 14:09:03.717+0900 I/MY_LOG  (18189): change
06-13 14:09:03.737+0900 I/MY_LOG  (18189): change
06-13 14:09:03.737+0900 I/MY_LOG  (18189): change
06-13 14:09:03.757+0900 I/MY_LOG  (18189): change
06-13 14:09:03.767+0900 I/MY_LOG  (18189): change
06-13 14:09:04.068+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x3200002 FAILED!
06-13 14:09:04.068+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x3200002 FAILED!
06-13 14:09:04.068+0900 I/ISE_MULTI(  804): isemain.cpp: slot_set_caps_mode(1028) > [0;36m[hidden state:true] mode=1[0m
06-13 14:09:04.088+0900 I/SWIFTKEY(  713): swiftkey_engine.cpp: IME_Generate_prediction(1498) > [0;36mGen prediction[0m
06-13 14:09:04.088+0900 W/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: refresh_lookup_table(4124) > [0;33mDo not need to insert.[0m
06-13 14:09:04.108+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is e0[0m
06-13 14:09:04.108+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is a0[0m
06-13 14:09:04.108+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 30[0m
06-13 14:09:04.118+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 20[0m
06-13 14:09:04.118+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 10[0m
06-13 14:09:04.138+0900 I/SWIFTKEY(  713): swiftkey_engine.cpp: IME_Generate_prediction(1498) > [0;36mGen prediction[0m
06-13 14:09:04.138+0900 W/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: refresh_lookup_table(4124) > [0;33mDo not need to insert.[0m
06-13 14:09:04.158+0900 W/CANDIDATE(  804): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
06-13 14:09:04.158+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is d0[0m
06-13 14:09:04.168+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
06-13 14:09:04.168+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:04.168+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
06-13 14:09:04.168+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:04.168+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:04.168+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:04.168+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:04.168+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:04.168+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:04.168+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:04.168+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:04.168+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
06-13 14:09:04.168+0900 E/ISE_MULTI(  804): ise.cpp: update_keyboard_geometry(598) > [0;31mg_main_window_rect.height 577  rect->height : 577[0m
06-13 14:09:04.208+0900 I/ISE_MULTI(  804): privatekeys.cpp: ise_update_Sym_private_key_for_lang(2283) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
06-13 14:09:04.278+0900 W/CANDIDATE(  804): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
06-13 14:09:04.288+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
06-13 14:09:04.288+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:04.288+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
06-13 14:09:04.288+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:04.288+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:04.288+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:04.288+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:04.288+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:04.288+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:04.288+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:04.288+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:04.288+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
06-13 14:09:04.298+0900 I/ISE_MULTI(  804): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=0[0m
06-13 14:09:04.298+0900 W/CANDIDATE(  804): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
06-13 14:09:04.298+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
06-13 14:09:04.298+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:04.298+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
06-13 14:09:04.298+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:04.298+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:04.298+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:04.298+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:04.298+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:04.298+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:04.298+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:04.298+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:04.298+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
06-13 14:09:04.388+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(804) status(3)
06-13 14:09:05.849+0900 E/EFL     (  342): ecore_x<342> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17532058
06-13 14:09:05.849+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17532058
06-13 14:09:06.009+0900 E/ISE_MULTI(  804): ise-language-change.cpp: ise_show_space_flick_language_change_popup(403) > [0;31m[English(UK)]lang_popup_width: 436, lang_popup_height: 90[0m
06-13 14:09:06.039+0900 E/ISE_MULTI(  804): ise-language-change.cpp: ise_show_space_flick_language_change_popup(569) > [0;31mError in elm_scroller_child_size_get 726[0m
06-13 14:09:06.089+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(804) status(0)
06-13 14:09:06.210+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17532424
06-13 14:09:06.210+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 20[0m
06-13 14:09:06.220+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: reload_config_thread(219) > [0;36mg_prediction_setting_value = [1], arg = [1], try--1[0m
06-13 14:09:06.220+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 10[0m
06-13 14:09:06.320+0900 I/SWIFTKEY(  713): swiftkey_engine.cpp: IME_Gen_layout_files(1942) > [0;36mgenerate : --------- [ 1] Code [en_GB] | block size [832]
06-13 14:09:06.320+0900 I/SWIFTKEY(  713): [0m
06-13 14:09:06.360+0900 E/SWIFTKEY(  713): swiftkey_engine.cpp: IME_Gen_layout_files(1999) > [0;31m[0m
06-13 14:09:06.380+0900 W/CANDIDATE(  804): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
06-13 14:09:06.380+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
06-13 14:09:06.390+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:06.390+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
06-13 14:09:06.390+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:06.390+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:06.390+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:06.390+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:06.390+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:06.390+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:06.390+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:06.390+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:06.390+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
06-13 14:09:06.390+0900 I/SWIFTKEY(  713): swiftkey_engine.cpp: IME_Generate_prediction(1498) > [0;36mGen prediction[0m
06-13 14:09:06.390+0900 W/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: refresh_lookup_table(4124) > [0;33mDo not need to insert.[0m
06-13 14:09:06.400+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 30[0m
06-13 14:09:06.410+0900 I/SWIFTKEY(  713): swiftkey_engine.cpp: IME_Generate_prediction(1498) > [0;36mGen prediction[0m
06-13 14:09:06.410+0900 W/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: refresh_lookup_table(4124) > [0;33mDo not need to insert.[0m
06-13 14:09:06.430+0900 I/ISE_MULTI(  804): privatekeys.cpp: ise_update_Sym_private_key_for_lang(2283) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
06-13 14:09:06.440+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 60[0m
06-13 14:09:06.480+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is d0[0m
06-13 14:09:06.500+0900 W/CANDIDATE(  804): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
06-13 14:09:06.510+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
06-13 14:09:06.510+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:06.510+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
06-13 14:09:06.510+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:06.510+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:06.510+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:06.510+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:06.510+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:06.510+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:06.510+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:06.510+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:06.510+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
06-13 14:09:06.580+0900 W/CANDIDATE(  804): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
06-13 14:09:06.590+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
06-13 14:09:06.590+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:06.590+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
06-13 14:09:06.590+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:06.590+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:06.590+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:06.590+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:06.590+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:06.590+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:06.590+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:06.590+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:06.590+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
06-13 14:09:07.040+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-13 14:09:07.070+0900 E/EFL     (  342): ecore_x<342> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17533277
06-13 14:09:07.070+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17533277
06-13 14:09:07.481+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(804) status(0)
06-13 14:09:07.741+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17533954
06-13 14:09:07.741+0900 E/ISE_MULTI(  804): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[607]  Y[144] aspect ratio is x[1.000000] y[1.000000][0m
06-13 14:09:07.741+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
06-13 14:09:07.741+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
06-13 14:09:07.771+0900 E/EFL     (18189): ecore_x<18189> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
06-13 14:09:07.771+0900 E/EFL     (18189): ecore_x<18189> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
06-13 14:09:07.771+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 30[0m
06-13 14:09:07.801+0900 I/ISE_MULTI(  804): isemain.cpp: slot_set_caps_mode(1028) > [0;36m[hidden state:false] mode=0[0m
06-13 14:09:08.011+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: prediction_gen_timer(159) > [0;36mprediction_gen_timer[0m
06-13 14:09:08.061+0900 I/SWIFTKEY(  713): swiftkey_engine.cpp: IME_Generate_prediction_TH(1695) > [0;36mGen prediction[0m
06-13 14:09:08.061+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: prediction_gen_thread(144) > [0;36mpredic gen set [1][0m
06-13 14:09:08.061+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 70[0m
06-13 14:09:08.071+0900 E/EFL     (  342): ecore_x<342> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17534279
06-13 14:09:08.071+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17534279
06-13 14:09:08.131+0900 W/CANDIDATE(  804): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
06-13 14:09:08.141+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
06-13 14:09:08.141+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:08.141+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
06-13 14:09:08.141+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:08.141+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:08.141+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:08.141+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:08.141+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:08.141+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:08.141+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:08.141+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:08.141+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
06-13 14:09:08.152+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17534355
06-13 14:09:08.152+0900 E/ISE_MULTI(  804): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[430]  Y[378] aspect ratio is x[1.000000] y[1.000000][0m
06-13 14:09:08.162+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
06-13 14:09:08.162+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
06-13 14:09:08.172+0900 E/EFL     (18189): ecore_x<18189> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
06-13 14:09:08.182+0900 E/EFL     (18189): ecore_x<18189> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
06-13 14:09:08.182+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(804) status(0)
06-13 14:09:08.412+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: prediction_gen_timer(159) > [0;36mprediction_gen_timer[0m
06-13 14:09:08.422+0900 I/SWIFTKEY(  713): swiftkey_engine.cpp: IME_Generate_prediction_TH(1695) > [0;36mGen prediction[0m
06-13 14:09:08.422+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: prediction_gen_thread(144) > [0;36mpredic gen set [1][0m
06-13 14:09:08.432+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 70[0m
06-13 14:09:08.432+0900 W/CANDIDATE(  804): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
06-13 14:09:08.432+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
06-13 14:09:08.432+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:08.432+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
06-13 14:09:08.432+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:08.432+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:08.432+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:08.432+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:08.432+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:08.432+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:08.442+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:08.442+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:09:08.442+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 10, line_count = 2[0m
06-13 14:09:09.263+0900 E/EFL     (18189): ecore_x<18189> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17535467
06-13 14:09:09.343+0900 E/EFL     (18189): ecore_x<18189> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17535555
06-13 14:09:09.353+0900 I/ISE_MULTI(  804): isemain.cpp: slot_reset_ise_input_context(1280) > [0;36m[hidden state:false][0m
06-13 14:09:09.363+0900 I/SWIFTKEY(  713): swiftkey_engine.cpp: IME_Learn_sentence(2373) > [0;36mDLM write[0m
06-13 14:09:09.373+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x3200002 FAILED!
06-13 14:09:09.393+0900 I/ISE_MULTI(  804): xt9-setting.cpp: xt9_change_onoff(165) > [0;36mPrediction OFF[0m
06-13 14:09:09.413+0900 I/MY_LOG  (18189): change
06-13 14:09:09.443+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is e0[0m
06-13 14:09:09.443+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is a0[0m
06-13 14:09:09.443+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 30[0m
06-13 14:09:09.443+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 20[0m
06-13 14:09:09.443+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 10[0m
06-13 14:09:09.473+0900 W/CANDIDATE(  804): soft_candidate.cpp: ui_candidate_hide(927) > [0;33mHide[0m
06-13 14:09:09.473+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is d0[0m
06-13 14:09:09.473+0900 E/ISE_MULTI(  804): ise.cpp: update_keyboard_geometry(598) > [0;31mg_main_window_rect.height 577  rect->height : 505[0m
06-13 14:09:09.523+0900 I/ISE_MULTI(  804): privatekeys.cpp: ise_update_Sym_private_key_for_lang(2283) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
06-13 14:09:09.613+0900 I/ISE_MULTI(  804): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=0[0m
06-13 14:09:09.773+0900 E/EFL     (  342): ecore_x<342> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17535981
06-13 14:09:09.773+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17535981
06-13 14:09:09.803+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17536004
06-13 14:09:09.803+0900 E/ISE_MULTI(  804): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[513]  Y[226] aspect ratio is x[1.000000] y[1.000000][0m
06-13 14:09:09.803+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
06-13 14:09:09.803+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
06-13 14:09:09.813+0900 I/MY_LOG  (18189): change
06-13 14:09:09.813+0900 I/ISE_MULTI(  804): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=1[0m
06-13 14:09:09.813+0900 E/EFL     (18189): ecore_x<18189> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
06-13 14:09:09.833+0900 E/EFL     (18189): ecore_x<18189> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
06-13 14:09:09.883+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(804) status(0)
06-13 14:09:09.983+0900 E/EFL     (  342): ecore_x<342> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17536192
06-13 14:09:09.983+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17536192
06-13 14:09:10.073+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17536225
06-13 14:09:10.073+0900 E/ISE_MULTI(  804): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[514]  Y[247] aspect ratio is x[1.000000] y[1.000000][0m
06-13 14:09:10.073+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
06-13 14:09:10.073+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
06-13 14:09:10.083+0900 I/MY_LOG  (18189): change
06-13 14:09:10.083+0900 I/ISE_MULTI(  804): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=2[0m
06-13 14:09:10.083+0900 I/MY_LOG  (18189): change
06-13 14:09:10.083+0900 E/EFL     (18189): ecore_x<18189> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
06-13 14:09:10.083+0900 E/EFL     (18189): ecore_x<18189> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
06-13 14:09:10.113+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(804) status(0)
06-13 14:09:10.314+0900 E/EFL     (18189): ecore_x<18189> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17536520
06-13 14:09:10.394+0900 E/EFL     (18189): ecore_x<18189> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17536608
06-13 14:09:10.404+0900 I/ISE_MULTI(  804): isemain.cpp: slot_reset_ise_input_context(1280) > [0;36m[hidden state:false][0m
06-13 14:09:10.414+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x3200002 FAILED!
06-13 14:09:10.494+0900 W/CANDIDATE(  804): soft_candidate.cpp: ui_candidate_hide(927) > [0;33mHide[0m
06-13 14:09:10.494+0900 E/ISE_MULTI(  804): ise.cpp: update_keyboard_geometry(598) > [0;31mg_main_window_rect.height 505  rect->height : 505[0m
06-13 14:09:10.554+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is e0[0m
06-13 14:09:10.554+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is a0[0m
06-13 14:09:10.554+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 30[0m
06-13 14:09:10.554+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 20[0m
06-13 14:09:10.554+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 10[0m
06-13 14:09:10.554+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is d0[0m
06-13 14:09:10.554+0900 I/ISE_MULTI(  804): privatekeys.cpp: ise_update_Sym_private_key_for_lang(2283) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
06-13 14:09:10.644+0900 I/ISE_MULTI(  804): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=0[0m
06-13 14:09:11.074+0900 E/EFL     (  342): ecore_x<342> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17537281
06-13 14:09:11.074+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17537281
06-13 14:09:11.184+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17537347
06-13 14:09:11.184+0900 E/ISE_MULTI(  804): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[496]  Y[260] aspect ratio is x[1.000000] y[1.000000][0m
06-13 14:09:11.184+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
06-13 14:09:11.184+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
06-13 14:09:11.204+0900 I/MY_LOG  (18189): change
06-13 14:09:11.204+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(804) status(0)
06-13 14:09:11.214+0900 E/EFL     (18189): ecore_x<18189> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
06-13 14:09:11.225+0900 E/EFL     (18189): ecore_x<18189> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
06-13 14:09:11.235+0900 I/ISE_MULTI(  804): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=1[0m
06-13 14:09:11.245+0900 E/EFL     (  342): ecore_x<342> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17537458
06-13 14:09:11.255+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17537458
06-13 14:09:11.325+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17537513
06-13 14:09:11.325+0900 E/ISE_MULTI(  804): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[498]  Y[254] aspect ratio is x[1.000000] y[1.000000][0m
06-13 14:09:11.325+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
06-13 14:09:11.325+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
06-13 14:09:11.325+0900 I/ISE_MULTI(  804): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=2[0m
06-13 14:09:11.325+0900 I/MY_LOG  (18189): change
06-13 14:09:11.325+0900 I/MY_LOG  (18189): change
06-13 14:09:11.335+0900 E/EFL     (18189): ecore_x<18189> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
06-13 14:09:11.345+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(804) status(0)
06-13 14:09:11.345+0900 E/EFL     (18189): ecore_x<18189> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
06-13 14:09:11.875+0900 E/EFL     (18189): ecore_x<18189> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17538080
06-13 14:09:11.875+0900 I/MY_LOG  (18189): Button pressed
06-13 14:09:11.975+0900 E/EFL     (18189): ecore_x<18189> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17538170
06-13 14:09:11.985+0900 I/ISE_MULTI(  804): isemain.cpp: slot_reset_ise_input_context(1280) > [0;36m[hidden state:false][0m
06-13 14:09:11.985+0900 I/MY_LOG  (18189): Button unpressed
06-13 14:09:12.726+0900 E/AUL_AMD (  607): amd_launch.c: _amd_proc_find_proc_info(1914) > proc info not found
06-13 14:09:15.128+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 18189 pgid = 18189
06-13 14:09:15.128+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(18189)
06-13 14:09:15.128+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:09:15.148+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x3200002 FAILED!
06-13 14:09:15.198+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(3)
06-13 14:09:15.198+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 14:09:15.198+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 14:09:15.198+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(1167)
06-13 14:09:15.198+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: fg
06-13 14:09:15.208+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(0)
06-13 14:09:15.228+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: RESUME State: PAUSED
06-13 14:09:15.228+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 14:09:15.228+0900 E/cluster-home( 1167): homescreen.cpp: OnResume(233) >  app resume
06-13 14:09:15.228+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:09:15.248+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-13 14:09:15.248+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-13 14:09:15.248+0900 W/AUL     ( 1355): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1355, appid: live-com.samsung.browser, status: fg
06-13 14:09:15.268+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:09:15.268+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 14:09:15.268+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 14:09:15.268+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 14:09:15.278+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:09:15.278+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 18189
06-13 14:09:15.278+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 18189
06-13 14:09:15.278+0900 I/TIZEN_N_SOUND_MANAGER(  910): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=8, ret=0x0
06-13 14:09:15.278+0900 E/TIZEN_N_SOUND_MANAGER(  910): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-13 14:09:15.278+0900 I/TIZEN_N_SOUND_MANAGER(  910): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
06-13 14:09:15.278+0900 E/TIZEN_N_SOUND_MANAGER(  910): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-13 14:09:15.288+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:09:15.288+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 18189
06-13 14:09:15.319+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [org.exampl] 
06-13 14:09:15.319+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 14:09:15.329+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 14:09:15.329+0900 I/Tizen::App( 1175): (243) > App[org.example.client] pid[18189] terminate event is forwarded
06-13 14:09:15.329+0900 I/Tizen::System( 1175): (256) > osp.accessorymanager.service provider is found.
06-13 14:09:15.329+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [org.example.client, 18189, ]
06-13 14:09:15.329+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 14:09:15.329+0900 I/Tizen::App( 1175): (506) > TerminatedApp(org.example.client)
06-13 14:09:15.329+0900 I/Tizen::App( 1175): (512) > Not registered pid(18189)
06-13 14:09:15.329+0900 I/Tizen::System( 1175): (246) > Terminated app [org.example.client]
06-13 14:09:15.329+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 14:09:15.339+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 14:09:15.339+0900 I/Tizen::App( 1175): (782) > Finished invoking application event listener for org.example.client, 18189.
06-13 14:09:15.339+0900 W/CRASH_MANAGER(18544): worker.c: worker_job(1199) > 0618189636c69149733055
