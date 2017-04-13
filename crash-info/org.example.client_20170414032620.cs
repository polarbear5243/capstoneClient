S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 9414
Date: 2017-04-14 03:26:20+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 9414, uid 5000)

Register Information
r0   = 0xbec30eec, r1   = 0xd2bdf846
r2   = 0x00000000, r3   = 0x00000000
r4   = 0xb27bd3f1, r5   = 0xb75ea708
r6   = 0xb77c1378, r7   = 0xbec30fd0
r8   = 0x800f63b5, r9   = 0xb5ec0708
r10  = 0xb77be1e0, fp   = 0x00000000
ip   = 0x800f63b5, sp   = 0xbec30fb8
lr   = 0xb27bd415, pc   = 0xd2bdf844
cpsr = 0x600f0010

Memory Information
MemTotal:   987012 KB
MemFree:    144036 KB
Buffers:     48268 KB
Cached:     324724 KB
VmPeak:     147552 KB
VmSize:     146396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       30804 KB
VmRSS:       29912 KB
VmData:      47036 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35828 KB
VmPTE:         108 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 9414 TID = 9414
9414 9417 9463 9464 9474 

Maps Information
af1ec000 af9eb000 rw-p [stack:9474]
b065d000 b066e000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b0f06000 b0f0b000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b1359000 b1361000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1373000 b1b72000 rw-p [stack:9464]
b1b72000 b1b73000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b83000 b1b97000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1bab000 b1bac000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1bbc000 b1bbf000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1bd0000 b1bd1000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1be1000 b1be3000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1bf3000 b1bf5000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c05000 b1c15000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c25000 b1c31000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c43000 b2442000 rw-p [stack:9463]
b2773000 b277a000 r-xp /usr/lib/libefl-extension.so.0.1.0
b278d000 b2793000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27a3000 b27cb000 r-xp /opt/usr/apps/org.example.client/bin/client
b2924000 b2a07000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a3e000 b2a66000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a78000 b3277000 rw-p [stack:9417]
b3277000 b3279000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3289000 b3293000 r-xp /lib/libnss_files-2.20-2014.11.so
b32a4000 b32ad000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32be000 b32cf000 r-xp /lib/libnsl-2.20-2014.11.so
b32e2000 b32e8000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32f9000 b32fa000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3322000 b3329000 r-xp /usr/lib/libminizip.so.1.0.0
b3339000 b333e000 r-xp /usr/lib/libstorage.so.0.1
b334e000 b33ad000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33c3000 b33d7000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33e7000 b342b000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b343b000 b3443000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3453000 b3483000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3496000 b354f000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3563000 b35b6000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b35c7000 b35e2000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35f2000 b36b3000 r-xp /usr/lib/libprotobuf.so.9.0.1
b36c6000 b36d6000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36e6000 b36f3000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3704000 b370b000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b371b000 b375c000 r-xp /usr/lib/libmdm.so.1.2.12
b376c000 b3774000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3783000 b3793000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37b4000 b3814000 r-xp /usr/lib/libasound.so.2.0.0
b3826000 b3829000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3839000 b383c000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b384c000 b3851000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3861000 b3862000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3872000 b387d000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3891000 b3898000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38a8000 b38ae000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38be000 b38c3000 r-xp /usr/lib/libmmfsession.so.0.0.1
b38d3000 b38ee000 r-xp /usr/lib/libmmfsound.so.0.1.0
b38fe000 b3905000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3915000 b3918000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3929000 b3957000 r-xp /usr/lib/libidn.so.11.5.44
b3967000 b397d000 r-xp /usr/lib/libnghttp2.so.5.4.0
b398e000 b3998000 r-xp /usr/lib/libcares.so.2.1.0
b39a8000 b39b2000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b39c2000 b39c4000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b39d4000 b39d5000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39e5000 b39e9000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39fa000 b3a22000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a33000 b3a5c000 r-xp /usr/lib/libturbojpeg.so
b3a7c000 b3a82000 r-xp /usr/lib/libgif.so.4.1.6
b3a92000 b3ad8000 r-xp /usr/lib/libcurl.so.4.3.0
b3ae9000 b3b0a000 r-xp /usr/lib/libexif.so.12.3.3
b3b25000 b3b3a000 r-xp /usr/lib/libtts.so
b3b4b000 b3b53000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b63000 b3c29000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c49000 b3d41000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d60000 b3e2e000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e45000 b3e47000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e57000 b3e5d000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e6d000 b3e90000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3ea1000 b3ea3000 r-xp /usr/lib/libappsvc.so.0.1.0
b3eb3000 b3eb5000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3ec6000 b3ecb000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3ee2000 b3ee4000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3ef4000 b3efb000 r-xp /usr/lib/libsensord-share.so
b3f0b000 b3f23000 r-xp /usr/lib/libsensor.so.1.1.0
b3f34000 b3f37000 r-xp /usr/lib/libXv.so.1.0.0
b3f47000 b3f4c000 r-xp /usr/lib/libutilX.so.1.1.0
b3f5c000 b3f61000 r-xp /usr/lib/libappcore-common.so.1.1
b3f71000 b3f78000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f8b000 b3f8f000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3fa0000 b407e000 r-xp /usr/lib/libCOREGL.so.4.0
b409e000 b40a1000 r-xp /usr/lib/libuuid.so.1.3.0
b40b1000 b40c8000 r-xp /usr/lib/libblkid.so.1.1.0
b40d9000 b40db000 r-xp /usr/lib/libXau.so.6.0.0
b40eb000 b4132000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4144000 b414a000 r-xp /usr/lib/libjson-c.so.2.0.1
b415b000 b415f000 r-xp /usr/lib/libogg.so.0.7.1
b416f000 b4191000 r-xp /usr/lib/libvorbis.so.0.4.3
b41a1000 b4285000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42a1000 b42a4000 r-xp /usr/lib/libEGL.so.1.4
b42b5000 b42bb000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42cb000 b42cd000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b42dd000 b42ea000 r-xp /usr/lib/libGLESv2.so.2.0
b42fb000 b435d000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4372000 b438a000 r-xp /usr/lib/libmount.so.1.1.0
b439c000 b43b0000 r-xp /usr/lib/libxcb.so.1.1.0
b43c0000 b43c7000 r-xp /lib/libcrypt-2.20-2014.11.so
b43ff000 b4401000 r-xp /usr/lib/libiri.so
b4411000 b441c000 r-xp /usr/lib/libgpg-error.so.0.15.0
b442d000 b4463000 r-xp /usr/lib/libpulse.so.0.16.2
b4474000 b44b7000 r-xp /usr/lib/libsndfile.so.1.0.25
b44cc000 b44e1000 r-xp /lib/libexpat.so.1.5.2
b44f3000 b45b1000 r-xp /usr/lib/libcairo.so.2.11200.14
b45c5000 b45cd000 r-xp /usr/lib/libdrm.so.2.4.0
b45dd000 b45e0000 r-xp /usr/lib/libdri2.so.0.0.0
b45f0000 b463e000 r-xp /usr/lib/libssl.so.1.0.0
b4653000 b465f000 r-xp /usr/lib/libeeze.so.1.13.0
b4670000 b4679000 r-xp /usr/lib/libethumb.so.1.13.0
b4689000 b468c000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b469c000 b4853000 r-xp /usr/lib/libcrypto.so.1.0.0
b563e000 b5647000 r-xp /usr/lib/libXi.so.6.1.0
b5657000 b5659000 r-xp /usr/lib/libXgesture.so.7.0.0
b5669000 b566d000 r-xp /usr/lib/libXtst.so.6.1.0
b567d000 b5683000 r-xp /usr/lib/libXrender.so.1.3.0
b5693000 b5699000 r-xp /usr/lib/libXrandr.so.2.2.0
b56a9000 b56ab000 r-xp /usr/lib/libXinerama.so.1.0.0
b56bc000 b56bf000 r-xp /usr/lib/libXfixes.so.3.1.0
b56cf000 b56da000 r-xp /usr/lib/libXext.so.6.4.0
b56ea000 b56ec000 r-xp /usr/lib/libXdamage.so.1.1.0
b56fc000 b56fe000 r-xp /usr/lib/libXcomposite.so.1.0.0
b570e000 b57f0000 r-xp /usr/lib/libX11.so.6.3.0
b5804000 b580b000 r-xp /usr/lib/libXcursor.so.1.0.2
b581b000 b5833000 r-xp /usr/lib/libudev.so.1.6.0
b5835000 b5838000 r-xp /lib/libattr.so.1.1.0
b5848000 b5868000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5869000 b586e000 r-xp /usr/lib/libffi.so.6.0.2
b587f000 b5897000 r-xp /lib/libz.so.1.2.8
b58a7000 b58a9000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58b9000 b598e000 r-xp /usr/lib/libxml2.so.2.9.2
b59a3000 b5a3e000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a5a000 b5a5d000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a6d000 b5a86000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a97000 b5aa8000 r-xp /lib/libresolv-2.20-2014.11.so
b5abc000 b5b36000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b4b000 b5b4d000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b5d000 b5b64000 r-xp /usr/lib/libembryo.so.1.13.0
b5b74000 b5b7e000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b8f000 b5ba7000 r-xp /usr/lib/libpng12.so.0.50.0
b5bb8000 b5bdb000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bfc000 b5c10000 r-xp /usr/lib/libector.so.1.13.0
b5c21000 b5c39000 r-xp /usr/lib/liblua-5.1.so
b5c4a000 b5ca1000 r-xp /usr/lib/libfreetype.so.6.11.3
b5cb5000 b5cdd000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cee000 b5d01000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d12000 b5d4c000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d5d000 b5d6b000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d7b000 b5d83000 r-xp /usr/lib/libtbm.so.1.0.0
b5d93000 b5da0000 r-xp /usr/lib/libeio.so.1.13.0
b5db0000 b5db2000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5dc2000 b5dc7000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5dd7000 b5dee000 r-xp /usr/lib/libefreet.so.1.13.0
b5e00000 b5e20000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e30000 b5e50000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e52000 b5e58000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e68000 b5e79000 r-xp /usr/lib/libemotion.so.1.13.0
b5e8a000 b5e91000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ea1000 b5eb0000 r-xp /usr/lib/libeo.so.1.13.0
b5ec1000 b5ed3000 r-xp /usr/lib/libecore_input.so.1.13.0
b5ee4000 b5ee9000 r-xp /usr/lib/libecore_file.so.1.13.0
b5ef9000 b5f12000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f22000 b5f3f000 r-xp /usr/lib/libeet.so.1.13.0
b5f58000 b5fa0000 r-xp /usr/lib/libeina.so.1.13.0
b5fb1000 b5fc1000 r-xp /usr/lib/libefl.so.1.13.0
b5fd2000 b60b7000 r-xp /usr/lib/libicuuc.so.51.1
b60d4000 b6214000 r-xp /usr/lib/libicui18n.so.51.1
b622b000 b6263000 r-xp /usr/lib/libecore_x.so.1.13.0
b6275000 b6278000 r-xp /lib/libcap.so.2.21
b6288000 b62b1000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62c2000 b62c9000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62db000 b6312000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6323000 b640e000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6421000 b649a000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64ac000 b64b1000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64c1000 b64cb000 r-xp /usr/lib/libvconf.so.0.2.45
b64db000 b64dd000 r-xp /usr/lib/libvasum.so.0.3.1
b64ed000 b64ef000 r-xp /usr/lib/libttrace.so.1.1
b64ff000 b6502000 r-xp /usr/lib/libiniparser.so.0
b6512000 b6538000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6548000 b654d000 r-xp /usr/lib/libxdgmime.so.1.1.0
b655e000 b6575000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6586000 b65f1000 r-xp /lib/libm-2.20-2014.11.so
b6602000 b6608000 r-xp /lib/librt-2.20-2014.11.so
b6619000 b6626000 r-xp /usr/lib/libunwind.so.8.0.1
b665c000 b6780000 r-xp /lib/libc-2.20-2014.11.so
b6795000 b67ae000 r-xp /lib/libgcc_s-4.9.so.1
b67be000 b68a0000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68b1000 b68db000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68ec000 b6928000 r-xp /usr/lib/libsystemd.so.0.4.0
b692a000 b69ad000 r-xp /usr/lib/libedje.so.1.13.0
b69c0000 b69de000 r-xp /usr/lib/libecore.so.1.13.0
b69fe000 b6b85000 r-xp /usr/lib/libevas.so.1.13.0
b6bba000 b6bce000 r-xp /lib/libpthread-2.20-2014.11.so
b6be2000 b6e16000 r-xp /usr/lib/libelementary.so.1.13.0
b6e45000 b6e49000 r-xp /usr/lib/libsmack.so.1.0.0
b6e59000 b6e60000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e70000 b6e72000 r-xp /usr/lib/libdlog.so.0.0.0
b6e82000 b6e85000 r-xp /usr/lib/libbundle.so.0.1.22
b6e95000 b6e97000 r-xp /lib/libdl-2.20-2014.11.so
b6ea8000 b6ec0000 r-xp /usr/lib/libaul.so.0.1.0
b6ed4000 b6ed9000 r-xp /usr/lib/libappcore-efl.so.1.1
b6eea000 b6ef7000 r-xp /usr/lib/liblptcp.so
b6f09000 b6f0d000 r-xp /usr/lib/libsys-assert.so
b6f1e000 b6f3e000 r-xp /lib/ld-2.20-2014.11.so
b6f4f000 b6f54000 r-xp /usr/bin/launchpad-loader
b7314000 b782b000 rw-p [heap]
bec11000 bec32000 rw-p [stack]
bec11000 bec32000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9414)
Call Stack Count: 1
 0: (0xd2bdf844) (null)
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
 [org.example.client]
04-14 03:25:40.593+0900 I/Tizen::Io( 1305): (729) > Entry not found
04-14 03:25:40.593+0900 W/AUL_AMD (  616): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 9035
04-14 03:25:40.593+0900 W/AUL_AMD (  616): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 9035
04-14 03:25:40.603+0900 E/RESOURCED(  648): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.682
04-14 03:25:40.613+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
04-14 03:25:40.623+0900 I/Tizen::System( 1305): (157) > change brightness system value.
04-14 03:25:40.623+0900 I/Tizen::App( 1305): (782) > Finished invoking application event listener for org.example.client, 9035.
04-14 03:25:40.643+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
04-14 03:25:40.643+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-14 03:25:40.643+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
04-14 03:25:40.643+0900 E/EFL     (  334): eo<334> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-14 03:25:40.653+0900 E/weather-widget( 1405): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-14 03:25:40.673+0900 I/Tizen::System( 1305): (259) > Active app [com.samsun], current [org.exampl] 
04-14 03:25:40.673+0900 I/Tizen::Io( 1305): (729) > Entry not found
04-14 03:25:40.693+0900 E/weather-widget( 1405): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-14 03:25:40.693+0900 W/CRASH_MANAGER( 9317): worker.c: worker_job(1199) > 1109035636c691492107940
04-14 03:25:40.713+0900 E/weather-common( 1405): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-14 03:25:40.723+0900 I/Tizen::System( 1305): (157) > change brightness system value.
04-14 03:25:40.733+0900 I/TIZEN_N_SOUND_MANAGER(  905): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-14 03:25:40.733+0900 E/TIZEN_N_SOUND_MANAGER(  905): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-14 03:25:40.743+0900 I/TIZEN_N_SOUND_MANAGER(  905): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-14 03:25:40.743+0900 E/TIZEN_N_SOUND_MANAGER(  905): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-14 03:25:40.743+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 15
04-14 03:25:40.793+0900 I/CAPI_NETWORK_CONNECTION( 1405): connection.c: connection_create(409) > New handle created[0xb86d2890]
04-14 03:25:40.793+0900 I/CAPI_NETWORK_CONNECTION( 1405): connection.c: connection_get_type(463) > Connected Network = 2
04-14 03:25:40.793+0900 I/CAPI_NETWORK_CONNECTION( 1405): connection.c: connection_destroy(427) > Destroy handle: 0xb86d2890
04-14 03:25:40.793+0900 E/weather-common( 1405): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-14 03:25:40.793+0900 E/weather-widget( 1405): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-14 03:25:40.793+0900 I/CAPI_WIDGET_APPLICATION( 1405): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-14 03:25:40.793+0900 I/CAPI_WIDGET_APPLICATION( 1405): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-14 03:25:40.793+0900 W/AUL     ( 1405): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1405, appid: com.samsung.weather-m-widget, status: fg
04-14 03:25:40.923+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28868376
04-14 03:25:41.243+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28868697
04-14 03:25:41.503+0900 W/cluster-view(  860): mainmenu-apps-view-impl.cpp: _OnScrollComplete(2308) >  booster timer is still running on apps-view, Stop boost timer!!!
04-14 03:25:41.794+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28869241
04-14 03:25:42.244+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28869694
04-14 03:25:42.504+0900 W/cluster-view(  860): mainmenu-apps-view-impl.cpp: _OnScrollComplete(2308) >  booster timer is still running on apps-view, Stop boost timer!!!
04-14 03:25:42.745+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28870198
04-14 03:25:42.845+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28870297
04-14 03:25:42.855+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
04-14 03:25:42.855+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 1
04-14 03:25:42.855+0900 W/AUL_AMD (  616): amd_launch.c: _start_app(2508) > caller pid : 860
04-14 03:25:42.865+0900 E/RESOURCED(  648): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
04-14 03:25:42.865+0900 E/RESOURCED(  648): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-14 03:25:42.865+0900 W/AUL_AMD (  616): amd_launch.c: _start_app(3052) > pad pid(-5)
04-14 03:25:42.865+0900 W/AUL_PAD ( 1560): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-14 03:25:42.865+0900 W/AUL_PAD ( 1560): launchpad.c: __send_result_to_caller(267) > Check app launching
04-14 03:25:42.885+0900 I/abc     ( 9311): abc
04-14 03:25:42.885+0900 I/CAPI_APPFW_APPLICATION( 9311): app_main.c: ui_app_main(789) > app_efl_main
04-14 03:25:42.885+0900 I/CAPI_APPFW_APPLICATION( 9311): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-14 03:25:42.915+0900 E/TBM     ( 9311): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-14 03:25:42.965+0900 W/AUL     (  616): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 9311, appid: org.example.client
04-14 03:25:42.965+0900 E/AUL     (  616): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-14 03:25:42.965+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(425) > request cmd(1) result(9311)
04-14 03:25:43.185+0900 I/APP_CORE( 9311): appcore-efl.c: __do_app(514) > [APP 9311] Event: RESET State: CREATED
04-14 03:25:43.185+0900 I/CAPI_APPFW_APPLICATION( 9311): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-14 03:25:43.195+0900 E/EFL     ( 9311): edje<9311> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-14 03:25:43.195+0900 E/EFL     ( 9311): By the power of Grayskull, your previous Embryo stack is now broken!
04-14 03:25:43.205+0900 E/EFL     ( 9311): edje<9311> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-14 03:25:43.205+0900 E/EFL     ( 9311): By the power of Grayskull, your previous Embryo stack is now broken!
04-14 03:25:43.205+0900 E/EFL     ( 9311): edje<9311> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-14 03:25:43.205+0900 E/EFL     ( 9311): By the power of Grayskull, your previous Embryo stack is now broken!
04-14 03:25:43.215+0900 W/APP_CORE( 9311): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5e00002
04-14 03:25:43.215+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 35
04-14 03:25:43.215+0900 E/EFL     (  334): eo<334> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-14 03:25:43.215+0900 E/EFL     (  334): eo<334> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-14 03:25:43.235+0900 I/Tizen::System( 1305): (259) > Active app [org.exampl], current [com.samsun] 
04-14 03:25:43.235+0900 I/Tizen::Io( 1305): (729) > Entry not found
04-14 03:25:43.245+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 15
04-14 03:25:43.255+0900 I/Tizen::System( 1305): (157) > change brightness system value.
04-14 03:25:43.325+0900 I/APP_CORE( 9311): appcore-efl.c: __do_app(514) > [APP 9311] Event: RESUME State: CREATED
04-14 03:25:43.325+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
04-14 03:25:43.325+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-14 03:25:43.325+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
04-14 03:25:43.325+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(860) status(4)
04-14 03:25:43.325+0900 W/AUL     (  616): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(860)
04-14 03:25:43.325+0900 W/AUL     (  616): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: bg
04-14 03:25:43.335+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(9311) status(3)
04-14 03:25:43.335+0900 W/AUL     (  616): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(9311)
04-14 03:25:43.335+0900 W/AUL     (  616): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 9311, appid: org.example.client, status: fg
04-14 03:25:43.335+0900 I/APP_CORE( 9311): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-14 03:25:43.335+0900 I/APP_CORE( 9311): appcore-efl.c: __do_app(625) > [APP 9311] Initial Launching, call the resume_cb
04-14 03:25:43.335+0900 I/CAPI_APPFW_APPLICATION( 9311): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-14 03:25:43.345+0900 I/CAPI_WIDGET_APPLICATION( 1405): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-14 03:25:43.345+0900 I/CAPI_WIDGET_APPLICATION( 1405): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-14 03:25:43.345+0900 W/AUL     ( 1405): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1405, appid: com.samsung.weather-m-widget, status: bg
04-14 03:25:43.686+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(9311) status(0)
04-14 03:25:44.006+0900 E/RESOURCED(  648): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.685
04-14 03:25:44.016+0900 I/Tizen::App( 1305): (499) > LaunchedApp(org.example.client)
04-14 03:25:44.016+0900 I/Tizen::App( 1305): (733) > Finished invoking application event listener for org.example.client, 9311.
04-14 03:25:44.146+0900 E/EFL     ( 9311): ecore_x<9311> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28871596
04-14 03:25:44.246+0900 E/EFL     ( 9311): ecore_x<9311> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28871695
04-14 03:25:44.556+0900 E/EFL     ( 9311): ecore_x<9311> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28872003
04-14 03:25:44.556+0900 I/MY_LOG  ( 9311): Button pressed
04-14 03:25:44.637+0900 E/EFL     ( 9311): ecore_x<9311> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28872080
04-14 03:25:44.647+0900 E/VCONF   ( 9311): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-14 03:25:44.647+0900 E/VCONF   ( 9311): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-14 03:25:44.647+0900 E/VCONF   ( 9311): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-14 03:25:44.647+0900 E/VCONF   ( 9311): vconf.c: vconf_get_bool(2729) > vconf_get_bool(9311) : db/ise/keysound error
04-14 03:25:44.647+0900 E/VCONF   ( 9311): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-14 03:25:44.647+0900 E/VCONF   ( 9311): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-14 03:25:44.697+0900 I/MY_LOG  ( 9311): Button unpressed
04-14 03:25:45.017+0900 I/UXT     ( 9346): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-14 03:25:45.497+0900 E/EFL     ( 9311): ecore_x<9311> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28872945
04-14 03:25:45.497+0900 I/MY_LOG  ( 9311): Button pressed
04-14 03:25:45.587+0900 E/EFL     ( 9311): ecore_x<9311> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28873033
04-14 03:25:45.587+0900 I/MY_LOG  ( 9311): Button unpressed
04-14 03:25:45.617+0900 D/basicui ( 9311): successed to load edc file
04-14 03:25:47.009+0900 E/EFL     ( 9311): ecore_x<9311> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28874453
04-14 03:25:47.099+0900 E/EFL     ( 9311): ecore_x<9311> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28874541
04-14 03:25:47.119+0900 D/basicui ( 9311): successed to load edc file
04-14 03:25:47.139+0900 I/MY_LOG  ( 9311): change
04-14 03:25:47.209+0900 I/MY_LOG  ( 9311): change
04-14 03:25:47.639+0900 E/INDICATOR(  645): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-14 03:25:47.639+0900 E/INDICATOR(  645): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-14 03:25:47.639+0900 E/INDICATOR(  645): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-14 03:25:47.639+0900 E/INDICATOR(  645): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-14 03:25:47.639+0900 E/INDICATOR(  645): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-14 03:25:47.639+0900 E/INDICATOR(  645): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-14 03:25:47.639+0900 E/INDICATOR(  645): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-14 03:25:47.639+0900 E/INDICATOR(  645): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-14 03:25:47.639+0900 E/INDICATOR(  645): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-14 03:25:47.639+0900 E/INDICATOR(  645): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-14 03:25:47.639+0900 E/INDICATOR(  645): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-14 03:25:47.639+0900 E/INDICATOR(  645): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-14 03:25:47.639+0900 E/INDICATOR(  645): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-14 03:25:47.639+0900 E/INDICATOR(  645): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-14 03:25:47.900+0900 E/EFL     ( 9311): ecore_x<9311> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28875345
04-14 03:25:48.340+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: MEM_FLUSH State: PAUSED
04-14 03:25:48.741+0900 E/EFL     ( 9311): ecore_x<9311> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28876185
04-14 03:25:49.391+0900 E/EFL     ( 9311): ecore_x<9311> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28876835
04-14 03:25:49.491+0900 W/CRASH_MANAGER( 9317): worker.c: worker_job(1199) > 1109311636c691492107949
04-14 03:25:49.521+0900 I/AUL_PAD ( 1560): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 9311 pgid = 9311
04-14 03:25:49.521+0900 I/AUL_PAD ( 1560): sigchild.h: __sigchild_action(143) > dead_pid(9311)
04-14 03:25:49.521+0900 E/EFL     (  334): eo<334> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-14 03:25:49.551+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
04-14 03:25:49.551+0900 W/AUL_AMD (  616): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-14 03:25:49.551+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-14 03:25:49.551+0900 W/AUL     (  616): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
04-14 03:25:49.551+0900 W/AUL     (  616): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
04-14 03:25:49.581+0900 I/AUL_PAD ( 1560): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-14 03:25:49.581+0900 I/AUL_PAD ( 1560): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-14 03:25:49.581+0900 E/AUL_PAD ( 1560): launchpad.c: main(698) > error reading sigchld info
04-14 03:25:49.591+0900 I/Tizen::App( 1305): (243) > App[org.example.client] pid[9311] terminate event is forwarded
04-14 03:25:49.591+0900 I/Tizen::System( 1305): (256) > osp.accessorymanager.service provider is found.
04-14 03:25:49.591+0900 I/Tizen::System( 1305): (196) > Accessory Owner is removed [org.example.client, 9311, ]
04-14 03:25:49.591+0900 I/Tizen::System( 1305): (256) > osp.system.service provider is found.
04-14 03:25:49.591+0900 I/Tizen::App( 1305): (506) > TerminatedApp(org.example.client)
04-14 03:25:49.591+0900 I/Tizen::App( 1305): (512) > Not registered pid(9311)
04-14 03:25:49.591+0900 I/Tizen::System( 1305): (246) > Terminated app [org.example.client]
04-14 03:25:49.591+0900 I/Tizen::Io( 1305): (729) > Entry not found
04-14 03:25:49.591+0900 I/ESD     (  895): esd_main.c: __esd_app_dead_handler(1773) > pid: 9311
04-14 03:25:49.591+0900 W/AUL_AMD (  616): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 9311
04-14 03:25:49.591+0900 W/AUL_AMD (  616): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 9311
04-14 03:25:49.601+0900 E/RESOURCED(  648): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.689
04-14 03:25:49.611+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
04-14 03:25:49.611+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
04-14 03:25:49.611+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-14 03:25:49.611+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
04-14 03:25:49.611+0900 I/Tizen::System( 1305): (157) > change brightness system value.
04-14 03:25:49.611+0900 I/Tizen::App( 1305): (782) > Finished invoking application event listener for org.example.client, 9311.
04-14 03:25:49.611+0900 E/EFL     (  334): eo<334> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-14 03:25:49.631+0900 E/weather-widget( 1405): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-14 03:25:49.651+0900 E/weather-widget( 1405): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-14 03:25:49.661+0900 E/weather-common( 1405): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-14 03:25:49.671+0900 I/Tizen::System( 1305): (259) > Active app [com.samsun], current [org.exampl] 
04-14 03:25:49.671+0900 I/Tizen::Io( 1305): (729) > Entry not found
04-14 03:25:49.681+0900 I/TIZEN_N_SOUND_MANAGER(  905): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-14 03:25:49.681+0900 E/TIZEN_N_SOUND_MANAGER(  905): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-14 03:25:49.681+0900 I/TIZEN_N_SOUND_MANAGER(  905): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-14 03:25:49.681+0900 E/TIZEN_N_SOUND_MANAGER(  905): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-14 03:25:49.691+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 15
04-14 03:25:49.721+0900 I/CAPI_NETWORK_CONNECTION( 1405): connection.c: connection_create(409) > New handle created[0xb867bef0]
04-14 03:25:49.721+0900 I/CAPI_NETWORK_CONNECTION( 1405): connection.c: connection_get_type(463) > Connected Network = 2
04-14 03:25:49.721+0900 I/CAPI_NETWORK_CONNECTION( 1405): connection.c: connection_destroy(427) > Destroy handle: 0xb867bef0
04-14 03:25:49.721+0900 E/weather-common( 1405): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-14 03:25:49.731+0900 E/weather-widget( 1405): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-14 03:25:49.731+0900 I/CAPI_WIDGET_APPLICATION( 1405): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-14 03:25:49.731+0900 I/CAPI_WIDGET_APPLICATION( 1405): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-14 03:25:49.731+0900 W/AUL     ( 1405): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1405, appid: com.samsung.weather-m-widget, status: fg
04-14 03:25:49.731+0900 I/Tizen::System( 1305): (157) > change brightness system value.
04-14 03:25:54.386+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28881831
04-14 03:25:54.516+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28881963
04-14 03:25:54.516+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
04-14 03:25:54.516+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 1
04-14 03:25:54.526+0900 W/AUL_AMD (  616): amd_launch.c: _start_app(2508) > caller pid : 860
04-14 03:25:54.536+0900 E/RESOURCED(  648): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
04-14 03:25:54.536+0900 E/RESOURCED(  648): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-14 03:25:54.536+0900 W/AUL_AMD (  616): amd_launch.c: _start_app(3052) > pad pid(-5)
04-14 03:25:54.536+0900 W/AUL_PAD ( 1560): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-14 03:25:54.536+0900 W/AUL_PAD ( 1560): launchpad.c: __send_result_to_caller(267) > Check app launching
04-14 03:25:54.556+0900 I/abc     ( 9346): abc
04-14 03:25:54.556+0900 I/CAPI_APPFW_APPLICATION( 9346): app_main.c: ui_app_main(789) > app_efl_main
04-14 03:25:54.556+0900 I/CAPI_APPFW_APPLICATION( 9346): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-14 03:25:54.586+0900 E/TBM     ( 9346): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-14 03:25:54.636+0900 W/AUL     (  616): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 9346, appid: org.example.client
04-14 03:25:54.636+0900 E/AUL     (  616): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-14 03:25:54.636+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(425) > request cmd(1) result(9346)
04-14 03:25:54.866+0900 I/APP_CORE( 9346): appcore-efl.c: __do_app(514) > [APP 9346] Event: RESET State: CREATED
04-14 03:25:54.866+0900 I/CAPI_APPFW_APPLICATION( 9346): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-14 03:25:54.876+0900 E/EFL     ( 9346): edje<9346> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-14 03:25:54.876+0900 E/EFL     ( 9346): By the power of Grayskull, your previous Embryo stack is now broken!
04-14 03:25:54.887+0900 E/EFL     ( 9346): edje<9346> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-14 03:25:54.887+0900 E/EFL     ( 9346): By the power of Grayskull, your previous Embryo stack is now broken!
04-14 03:25:54.887+0900 E/EFL     ( 9346): edje<9346> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-14 03:25:54.887+0900 E/EFL     ( 9346): By the power of Grayskull, your previous Embryo stack is now broken!
04-14 03:25:54.897+0900 W/APP_CORE( 9346): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6000002
04-14 03:25:54.897+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 35
04-14 03:25:54.907+0900 E/EFL     (  334): eo<334> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-14 03:25:54.907+0900 E/EFL     (  334): eo<334> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-14 03:25:54.917+0900 I/Tizen::System( 1305): (259) > Active app [org.exampl], current [com.samsun] 
04-14 03:25:54.927+0900 I/Tizen::Io( 1305): (729) > Entry not found
04-14 03:25:54.927+0900 I/Tizen::System( 1305): (157) > change brightness system value.
04-14 03:25:54.947+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 15
04-14 03:25:55.017+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
04-14 03:25:55.017+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-14 03:25:55.017+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
04-14 03:25:55.017+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(860) status(4)
04-14 03:25:55.017+0900 W/AUL     (  616): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(860)
04-14 03:25:55.017+0900 W/AUL     (  616): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: bg
04-14 03:25:55.027+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(9346) status(3)
04-14 03:25:55.027+0900 I/APP_CORE( 9346): appcore-efl.c: __do_app(514) > [APP 9346] Event: RESUME State: CREATED
04-14 03:25:55.027+0900 W/AUL     (  616): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(9346)
04-14 03:25:55.027+0900 W/AUL     (  616): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 9346, appid: org.example.client, status: fg
04-14 03:25:55.037+0900 I/CAPI_WIDGET_APPLICATION( 1405): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-14 03:25:55.037+0900 I/CAPI_WIDGET_APPLICATION( 1405): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-14 03:25:55.037+0900 W/AUL     ( 1405): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1405, appid: com.samsung.weather-m-widget, status: bg
04-14 03:25:55.047+0900 I/APP_CORE( 9346): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-14 03:25:55.047+0900 I/APP_CORE( 9346): appcore-efl.c: __do_app(625) > [APP 9346] Initial Launching, call the resume_cb
04-14 03:25:55.047+0900 I/CAPI_APPFW_APPLICATION( 9346): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-14 03:25:55.387+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(9346) status(0)
04-14 03:25:55.667+0900 E/RESOURCED(  648): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.691
04-14 03:25:55.677+0900 I/Tizen::App( 1305): (499) > LaunchedApp(org.example.client)
04-14 03:25:55.677+0900 I/Tizen::App( 1305): (733) > Finished invoking application event listener for org.example.client, 9346.
04-14 03:25:55.757+0900 E/EFL     ( 9346): ecore_x<9346> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28883202
04-14 03:25:55.867+0900 E/EFL     ( 9346): ecore_x<9346> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28883312
04-14 03:25:56.358+0900 E/EFL     ( 9346): ecore_x<9346> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28883800
04-14 03:25:56.358+0900 I/MY_LOG  ( 9346): Button pressed
04-14 03:25:56.468+0900 E/EFL     ( 9346): ecore_x<9346> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28883910
04-14 03:25:56.468+0900 E/VCONF   ( 9346): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-14 03:25:56.468+0900 E/VCONF   ( 9346): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-14 03:25:56.468+0900 E/VCONF   ( 9346): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-14 03:25:56.468+0900 E/VCONF   ( 9346): vconf.c: vconf_get_bool(2729) > vconf_get_bool(9346) : db/ise/keysound error
04-14 03:25:56.468+0900 E/VCONF   ( 9346): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-14 03:25:56.468+0900 E/VCONF   ( 9346): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-14 03:25:56.498+0900 I/UXT     ( 9414): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-14 03:25:56.528+0900 I/MY_LOG  ( 9346): Button unpressed
04-14 03:25:57.289+0900 E/EFL     ( 9346): ecore_x<9346> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28884729
04-14 03:25:57.289+0900 I/MY_LOG  ( 9346): Button pressed
04-14 03:25:57.399+0900 E/EFL     ( 9346): ecore_x<9346> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28884839
04-14 03:25:57.399+0900 I/MY_LOG  ( 9346): Button unpressed
04-14 03:25:57.439+0900 D/basicui ( 9346): successed to load edc file
04-14 03:25:58.740+0900 E/EFL     ( 9346): ecore_x<9346> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28886183
04-14 03:25:58.830+0900 E/EFL     ( 9346): ecore_x<9346> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28886271
04-14 03:25:58.860+0900 D/basicui ( 9346): successed to load edc file
04-14 03:25:58.880+0900 I/MY_LOG  ( 9346): change
04-14 03:25:58.960+0900 I/MY_LOG  ( 9346): change
04-14 03:26:00.022+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: MEM_FLUSH State: PAUSED
04-14 03:26:00.272+0900 I/INDICATOR(  645): clock.c: indicator_clock_changed_cb(195) > ""
04-14 03:26:00.272+0900 E/UXT     (  645): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 3:26
04-14 03:26:00.272+0900 I/INDICATOR(  645): clock.c: getTimeFormatted(176) > "time format : 오전 3:26"
04-14 03:26:00.272+0900 I/INDICATOR(  645): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 3:26"
04-14 03:26:00.272+0900 W/INDICATOR(  645): clock.c: indicator_clock_changed_cb(272) > 
04-14 03:26:00.272+0900 I/INDICATOR(  645): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145724326 Time: <font_size=31> </font_size> <font_size=31> 오전 3:26</font_size></font>"
04-14 03:26:03.185+0900 E/EFL     ( 9346): ecore_x<9346> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28890632
04-14 03:26:05.367+0900 E/EFL     ( 9346): ecore_x<9346> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28892809
04-14 03:26:05.587+0900 W/CRASH_MANAGER( 9317): worker.c: worker_job(1199) > 1109346636c691492107965
04-14 03:26:05.607+0900 E/EFL     (  334): eo<334> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-14 03:26:05.617+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
04-14 03:26:05.617+0900 W/AUL_AMD (  616): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-14 03:26:05.617+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-14 03:26:05.617+0900 W/AUL     (  616): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
04-14 03:26:05.617+0900 W/AUL     (  616): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
04-14 03:26:05.627+0900 I/AUL_PAD ( 1560): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 9346 pgid = 9346
04-14 03:26:05.627+0900 I/AUL_PAD ( 1560): sigchild.h: __sigchild_action(143) > dead_pid(9346)
04-14 03:26:05.667+0900 I/AUL_PAD ( 1560): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-14 03:26:05.667+0900 I/AUL_PAD ( 1560): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-14 03:26:05.667+0900 E/AUL_PAD ( 1560): launchpad.c: main(698) > error reading sigchld info
04-14 03:26:05.667+0900 I/ESD     (  895): esd_main.c: __esd_app_dead_handler(1773) > pid: 9346
04-14 03:26:05.667+0900 I/Tizen::App( 1305): (243) > App[org.example.client] pid[9346] terminate event is forwarded
04-14 03:26:05.667+0900 I/Tizen::System( 1305): (256) > osp.accessorymanager.service provider is found.
04-14 03:26:05.667+0900 I/Tizen::System( 1305): (196) > Accessory Owner is removed [org.example.client, 9346, ]
04-14 03:26:05.667+0900 I/Tizen::System( 1305): (256) > osp.system.service provider is found.
04-14 03:26:05.667+0900 I/Tizen::App( 1305): (506) > TerminatedApp(org.example.client)
04-14 03:26:05.667+0900 I/Tizen::App( 1305): (512) > Not registered pid(9346)
04-14 03:26:05.667+0900 I/Tizen::System( 1305): (246) > Terminated app [org.example.client]
04-14 03:26:05.667+0900 I/Tizen::Io( 1305): (729) > Entry not found
04-14 03:26:05.667+0900 W/AUL_AMD (  616): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 9346
04-14 03:26:05.667+0900 W/AUL_AMD (  616): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 9346
04-14 03:26:05.677+0900 E/RESOURCED(  648): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.695
04-14 03:26:05.677+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
04-14 03:26:05.687+0900 I/Tizen::System( 1305): (157) > change brightness system value.
04-14 03:26:05.687+0900 I/Tizen::App( 1305): (782) > Finished invoking application event listener for org.example.client, 9346.
04-14 03:26:05.697+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
04-14 03:26:05.697+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-14 03:26:05.697+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
04-14 03:26:05.697+0900 E/EFL     (  334): eo<334> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-14 03:26:05.717+0900 E/weather-widget( 1405): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-14 03:26:05.747+0900 I/Tizen::System( 1305): (259) > Active app [com.samsun], current [org.exampl] 
04-14 03:26:05.747+0900 I/Tizen::Io( 1305): (729) > Entry not found
04-14 03:26:05.767+0900 I/Tizen::System( 1305): (157) > change brightness system value.
04-14 03:26:05.777+0900 E/weather-widget( 1405): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-14 03:26:05.797+0900 I/TIZEN_N_SOUND_MANAGER(  905): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-14 03:26:05.797+0900 E/TIZEN_N_SOUND_MANAGER(  905): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-14 03:26:05.797+0900 I/TIZEN_N_SOUND_MANAGER(  905): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-14 03:26:05.797+0900 E/TIZEN_N_SOUND_MANAGER(  905): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-14 03:26:05.797+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 15
04-14 03:26:05.817+0900 E/weather-common( 1405): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-14 03:26:05.877+0900 I/CAPI_NETWORK_CONNECTION( 1405): connection.c: connection_create(409) > New handle created[0xb8688a70]
04-14 03:26:05.877+0900 I/CAPI_NETWORK_CONNECTION( 1405): connection.c: connection_get_type(463) > Connected Network = 2
04-14 03:26:05.877+0900 I/CAPI_NETWORK_CONNECTION( 1405): connection.c: connection_destroy(427) > Destroy handle: 0xb8688a70
04-14 03:26:05.877+0900 E/weather-common( 1405): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-14 03:26:05.887+0900 E/weather-widget( 1405): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-14 03:26:05.887+0900 I/CAPI_WIDGET_APPLICATION( 1405): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-14 03:26:05.887+0900 I/CAPI_WIDGET_APPLICATION( 1405): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-14 03:26:05.887+0900 W/AUL     ( 1405): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1405, appid: com.samsung.weather-m-widget, status: fg
04-14 03:26:08.179+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28895626
04-14 03:26:08.300+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28895747
04-14 03:26:08.310+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
04-14 03:26:08.310+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 1
04-14 03:26:08.310+0900 W/AUL_AMD (  616): amd_launch.c: _start_app(2508) > caller pid : 860
04-14 03:26:08.320+0900 E/RESOURCED(  648): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
04-14 03:26:08.320+0900 E/RESOURCED(  648): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-14 03:26:08.320+0900 W/AUL_AMD (  616): amd_launch.c: _start_app(3052) > pad pid(-5)
04-14 03:26:08.320+0900 W/AUL_PAD ( 1560): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-14 03:26:08.320+0900 W/AUL_PAD ( 1560): launchpad.c: __send_result_to_caller(267) > Check app launching
04-14 03:26:08.340+0900 I/abc     ( 9414): abc
04-14 03:26:08.340+0900 I/CAPI_APPFW_APPLICATION( 9414): app_main.c: ui_app_main(789) > app_efl_main
04-14 03:26:08.340+0900 I/CAPI_APPFW_APPLICATION( 9414): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-14 03:26:08.370+0900 E/TBM     ( 9414): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-14 03:26:08.420+0900 W/AUL     (  616): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 9414, appid: org.example.client
04-14 03:26:08.420+0900 E/AUL     (  616): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-14 03:26:08.420+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(425) > request cmd(1) result(9414)
04-14 03:26:08.640+0900 I/APP_CORE( 9414): appcore-efl.c: __do_app(514) > [APP 9414] Event: RESET State: CREATED
04-14 03:26:08.640+0900 I/CAPI_APPFW_APPLICATION( 9414): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-14 03:26:08.650+0900 E/EFL     ( 9414): edje<9414> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-14 03:26:08.650+0900 E/EFL     ( 9414): By the power of Grayskull, your previous Embryo stack is now broken!
04-14 03:26:08.660+0900 E/EFL     ( 9414): edje<9414> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-14 03:26:08.660+0900 E/EFL     ( 9414): By the power of Grayskull, your previous Embryo stack is now broken!
04-14 03:26:08.660+0900 E/EFL     ( 9414): edje<9414> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-14 03:26:08.660+0900 E/EFL     ( 9414): By the power of Grayskull, your previous Embryo stack is now broken!
04-14 03:26:08.670+0900 W/APP_CORE( 9414): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5e00002
04-14 03:26:08.680+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 35
04-14 03:26:08.680+0900 E/EFL     (  334): eo<334> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-14 03:26:08.680+0900 E/EFL     (  334): eo<334> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-14 03:26:08.700+0900 I/Tizen::System( 1305): (259) > Active app [org.exampl], current [com.samsun] 
04-14 03:26:08.700+0900 I/Tizen::Io( 1305): (729) > Entry not found
04-14 03:26:08.700+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 15
04-14 03:26:08.710+0900 I/Tizen::System( 1305): (157) > change brightness system value.
04-14 03:26:08.800+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
04-14 03:26:08.800+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-14 03:26:08.800+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
04-14 03:26:08.800+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(860) status(4)
04-14 03:26:08.800+0900 W/AUL     (  616): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(860)
04-14 03:26:08.800+0900 W/AUL     (  616): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: bg
04-14 03:26:08.800+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(9414) status(3)
04-14 03:26:08.810+0900 W/AUL     (  616): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(9414)
04-14 03:26:08.810+0900 W/AUL     (  616): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 9414, appid: org.example.client, status: fg
04-14 03:26:08.820+0900 I/CAPI_WIDGET_APPLICATION( 1405): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-14 03:26:08.820+0900 I/CAPI_WIDGET_APPLICATION( 1405): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-14 03:26:08.820+0900 W/AUL     ( 1405): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1405, appid: com.samsung.weather-m-widget, status: bg
04-14 03:26:08.820+0900 I/APP_CORE( 9414): appcore-efl.c: __do_app(514) > [APP 9414] Event: RESUME State: CREATED
04-14 03:26:08.830+0900 I/APP_CORE( 9414): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-14 03:26:08.830+0900 I/APP_CORE( 9414): appcore-efl.c: __do_app(625) > [APP 9414] Initial Launching, call the resume_cb
04-14 03:26:08.830+0900 I/CAPI_APPFW_APPLICATION( 9414): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-14 03:26:09.170+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(9414) status(0)
04-14 03:26:09.451+0900 E/RESOURCED(  648): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.697
04-14 03:26:09.461+0900 I/Tizen::App( 1305): (499) > LaunchedApp(org.example.client)
04-14 03:26:09.461+0900 I/Tizen::App( 1305): (733) > Finished invoking application event listener for org.example.client, 9414.
04-14 03:26:09.561+0900 E/EFL     ( 9414): ecore_x<9414> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28897001
04-14 03:26:09.631+0900 E/EFL     ( 9414): ecore_x<9414> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28897078
04-14 03:26:10.151+0900 E/EFL     ( 9414): ecore_x<9414> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28897606
04-14 03:26:10.151+0900 I/MY_LOG  ( 9414): Button pressed
04-14 03:26:10.211+0900 E/EFL     ( 9414): ecore_x<9414> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28897661
04-14 03:26:10.211+0900 E/VCONF   ( 9414): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-14 03:26:10.211+0900 E/VCONF   ( 9414): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-14 03:26:10.211+0900 E/VCONF   ( 9414): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-14 03:26:10.211+0900 E/VCONF   ( 9414): vconf.c: vconf_get_bool(2729) > vconf_get_bool(9414) : db/ise/keysound error
04-14 03:26:10.211+0900 E/VCONF   ( 9414): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-14 03:26:10.211+0900 E/VCONF   ( 9414): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-14 03:26:10.272+0900 I/MY_LOG  ( 9414): Button unpressed
04-14 03:26:10.292+0900 I/UXT     ( 9471): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-14 03:26:11.012+0900 E/EFL     ( 9414): ecore_x<9414> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28898464
04-14 03:26:11.012+0900 I/MY_LOG  ( 9414): Button pressed
04-14 03:26:11.132+0900 E/EFL     ( 9414): ecore_x<9414> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28898584
04-14 03:26:11.132+0900 I/MY_LOG  ( 9414): Button unpressed
04-14 03:26:11.162+0900 D/basicui ( 9414): successed to load edc file
04-14 03:26:12.344+0900 E/EFL     ( 9414): ecore_x<9414> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28899788
04-14 03:26:12.434+0900 E/EFL     ( 9414): ecore_x<9414> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28899887
04-14 03:26:12.474+0900 D/basicui ( 9414): successed to load edc file
04-14 03:26:12.504+0900 I/MY_LOG  ( 9414): change
04-14 03:26:12.574+0900 I/MY_LOG  ( 9414): change
04-14 03:26:13.805+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: MEM_FLUSH State: PAUSED
04-14 03:26:18.510+0900 E/EFL     ( 9414): ecore_x<9414> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28905950
04-14 03:26:19.010+0900 E/EFL     ( 9414): ecore_x<9414> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28906448
04-14 03:26:20.211+0900 E/EFL     ( 9414): ecore_x<9414> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28907652
04-14 03:26:20.321+0900 W/CRASH_MANAGER( 9317): worker.c: worker_job(1199) > 1109414636c69149210798
